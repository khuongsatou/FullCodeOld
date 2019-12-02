//==== To show data when page initially loads.
$(document).ready(function () {
    bindData();
});

//==== Get data from database, created HTML table and place inside #divData
function bindData() {

    $.ajax({
        type: "POST",
        url: location.pathname + "Default.aspx/getData",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        datatype: "jsondata",
        async: "true",
        success: function (response) {
            var msg = eval('(' + response.d + ')');
            if ($('#tblResult').length != 0) // remove table if it exists
            { $("#tblResult").remove(); }
            var table = "<table class='tblResult' id=tblResult><thead> <tr><th>Name</th><th>Email</th><th>Age</th><th>Actions</th></thead>  <tbody>";
            for (var i = 0; i <= (msg.length - 1) ; i++) {
                var row = "<tr>";
                row += '<td>' + msg[i].Name + '</td>';
                row += '<td>' + msg[i].Email + '</td>';
                row += '<td>' + msg[i].Age + '</td>';
                row += '<td><img src="edit.png" title="Edit record." onclick="bindRecordToEdit(' + msg[i].Id + ')" />  <img src="delete.png" onclick="deleteRecord(' + msg[i].Id + ')" title="Delete record." /></td>';

                row += '</tr>';
                table += row;
            }
            table += '</tbody></table>';
            $('#divData').html(table);
            $("#divData").slideDown("slow");

        },
        error: function (response) {
            alert(response.status + ' ' + response.statusText);
        }
    });
}

//==== Method to save data into database.
function saveData() {

    //==== Call validateData() Method to perform validation. This method will return 0 
    //==== if validation pass else returns number of validations fails.

    var errCount = validateData();
    //==== If validation pass save the data.
    if (errCount == 0) {
        var txtName = $("#txtName").val();
        var txtEmail = $("#txtEmail").val();
        var txtAge = $("#txtAge").val();
        $.ajax({
            type: "POST",
            url: location.pathname + "Default.aspx/saveData",
            data: "{name:'" + txtName + "',email:'" + txtEmail + "',age:'" + txtAge + "'}",
            contentType: "application/json; charset=utf-8",
            datatype: "jsondata",
            async: "true",
            success: function (response) {
                $(".errMsg ul").remove();
                var myObject = eval('(' + response.d + ')');
                if (myObject > 0) {
                    bindData();
                    $(".errMsg").append("<ul><li>Data saved successfully</li></ul>");
                }
                else {
                    $(".errMsg").append("<ul><li>Opppps something went wrong.</li></ul>");
                }
                $(".errMsg").show("slow");
                clear();
            },
            error: function (response) {
                alert(response.status + ' ' + response.statusText);
            }
        });
    }
}

//==== Method to update record.
function updateData() {

    //==== Call validateData() Method to perform validation. This method will return 0 
    //==== if validation pass else returns number of validations fails.

    var errCount = validateData();
    //==== If validation pass save the data.
    if (errCount == 0) {
        var txtName = $("#txtName").val();
        var txtEmail = $("#txtEmail").val();
        var txtAge = $("#txtAge").val();
        var id = $("#hfSelectedRecord").val();
        $.ajax({
            type: "POST",
            url: location.pathname + "Default.aspx/updateData",
            data: "{name:'" + txtName + "',email:'" + txtEmail + "',age:'" + txtAge + "',id:'" + id + "'}",
            contentType: "application/json; charset=utf-8",
            datatype: "jsondata",
            async: "true",
            success: function (response) {
                $(".errMsg ul").remove();
                var myObject = eval('(' + response.d + ')');
                if (myObject > 0) {
                    bindData();
                    $(".errMsg").append("<ul><li>Data updated successfully</li></ul>");
                }
                else {
                    $(".errMsg").append("<ul><li>Opppps something went wrong.</li></ul>");
                }
                $(".errMsg").show("slow");
                clear();
            },
            error: function (response) {
                alert(response.status + ' ' + response.statusText);
            }
        });
    }
}

//==== Method to delete a record
function deleteRecord(id) {
    //=== Show confirmation alert to user before delete a record.
    var ans = confirm("Are you sure to delete a record?");
    //=== If user pressed Ok then delete the record else do nothing.
    if (ans == true) {
        $.ajax({
            type: "POST",
            url: location.pathname + "Default.aspx/deleteRecord",
            data: "{id:'" + id + "'}",
            contentType: "application/json; charset=utf-8",
            datatype: "jsondata",
            async: "true",
            success: function (response) {
                //=== rebind data to remove delete record from the table.
                bindData();
                $(".errMsg ul").remove();
                clear();
            },
            error: function (response) {
                alert(response.status + ' ' + response.statusText);
            }
        });
    }


}

//==== Method to bind values of selected record into input controls for update operation.
function bindRecordToEdit(id) {
    $.ajax({
        type: "POST",
        url: location.pathname + "Default.aspx/bindRecordToEdit",
        data: "{id:'" + id + "'}",
        contentType: "application/json; charset=utf-8",
        datatype: "jsondata",
        async: "true",
        success: function (response) {
            var msg = eval('(' + response.d + ')');
            $("#txtName").val(msg.Name);
            $("#txtEmail").val(msg.Email);
            $("#txtAge").val(msg.Age);

            //=== store id of the selected record in hidden field so that we can use it later during 
            //=== update process.
            $("#hfSelectedRecord").val(id);

            //=== Hide save button and show update button.
            $("#btnSave").hide();
            $("#btnUpdate").css("display", "block");


        },
        error: function (response) {
            alert(response.status + ' ' + response.statusText);
        }
    });
}

//==== Method to validate textboxes
function validateData() {

    var txtName = $("#txtName").val();
    var txtEmail = $("#txtEmail").val();
    var txtAge = $("#txtAge").val();
    var errMsg = "";
    var errCount = 0;
    if (txtName.length <= 0) {
        errCount++;
        errMsg += "<li>Please enter Name.</li>";
    }
    if (txtEmail.length <= 0) {
        errCount++;
        errMsg += "<li>Please enter Email.</li>";
    }
    if (txtAge.length <= 0) {
        errCount++;
        errMsg += "<li>Please enter Age.</li>";
    }
    if (errCount > 0) {

        $(".errMsg ul").remove()
        $(".errMsg").append("<ul>" + errMsg + "</ul>");
        $(".errMsg").slideDown('slow');
    }
    return errCount;
}

//==== Method to clear input fields
function clear() {
    $("#txtName").val("");
    $("#txtEmail").val("");
    $("#txtAge").val("");

    //=== Hide update button and show save button.
    $("#btnSave").show();
    $("#btnUpdate").hide();
}

