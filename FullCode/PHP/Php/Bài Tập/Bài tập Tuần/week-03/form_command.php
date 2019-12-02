<html>
    <body>
        <?php 
            $name = $_POST['username'] ? $_POST['username'] : "";
            $email = $_POST['email'] ? $_POST['email'] : "";
        
            $error = null;
            if($name == "" || $email == ""){
                $error = "Please input data.";
                require "form_view.php";
            }
            else{
                echo "<p>Welcome " . $_POST["username"] . "</p>";
                echo "<p>Welcome " . $_POST["email"] . "</p>";
            }
        ?>
    </body>
</html>