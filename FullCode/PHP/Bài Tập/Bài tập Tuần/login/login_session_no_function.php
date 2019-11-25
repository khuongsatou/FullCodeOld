<?php
    session_start();
    if (isset($_SESSION['user'])) {
        echo "Hello " . $_SESSION['user'];
    }
    else {
        if (isset($_POST['username']) && isset($_POST['password'])) {
            $username = $_POST['username'];
            $password = $_POST['password'];
                // Connect DB
            $con = mysqli_connect('localhost', 'root', '');
            mysqli_select_db($con, 'Account');
            //echo "SELECT name FROM User WHERE username='$username' and password='$password'";
            $result = mysqli_query($con, "SELECT name FROM User WHERE username='$username' and password='$password'");
            //$row = mysqli_fetch_array($result, MYSQLI_BOTH);
            if (mysqli_num_rows($result) == 1) {
                echo "Hello " . $username;
                $_SESSION['user'] = $username;
            }
            else {
                echo "Login fail";
                include "login_view.php";
            }
        }
        else {
            include "login_view.php";
        }
    }
    
    
    // echo $username . ' - ' . $password;

    
?>