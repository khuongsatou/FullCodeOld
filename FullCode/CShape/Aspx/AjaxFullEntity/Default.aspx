<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://code.jquery.com/jquery-1.10.2.min.js"></script>
    <script src="myScript.js"></script>
    <style type="text/css">
        body {
            font-family: Verdana;
            font-size: 11px;
        }

        .errMsg {
            width: 200px;
            text-align: left;
            color: yellow;
            font: 12px arial;
            background: red;
            padding: 5px;
            display: none;
        }

        .tblResult {
            border-collapse: collapse;
        }

            .tblResult td {
                padding: 5px;
                border: 1px solid red;
            }

            .tblResult th {
                padding: 5px;
                border: 1px solid red;
            }

        img {
            cursor: pointer;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td colspan="2">
                    <div class="errMsg"></div>
                </td>
            </tr>
            <tr>
                <td><b>Name</b></td>
                <td>
                    <asp:TextBox runat="server" ID="txtName" /></td>
            </tr>
            <tr>
                <td><b>Email</b></td>
                <td>
                    <asp:TextBox runat="server" ID="txtEmail" /></td>
            </tr>
            <tr>
                <td><b>Age</b></td>
                <td>
                    <asp:TextBox runat="server" ID="txtAge" /></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <input type="button" onclick="saveData()" id="btnSave" value="Save" title="Save" />
                    <input type="button" onclick="updateData()" id="btnUpdate" value="Update" title="Update" style="display: none" />
                    <asp:HiddenField ID="hfSelectedRecord" runat="server" />

                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <div id="divData"></div>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
