<?php
    $username = $_POST['username'];
    $password = $_POST['password'];
    // echo $username . ' - ' . $password;

    // Connect DB
    $con = mysqli_connect('localhost', 'root', '');
    mysqli_select_db($con, 'Account');
    $result = mysqli_query($con, "SELECT name FROM User WHERE username='$username' and password='$password'");
    //$row = mysqli_fetch_array($result, MYSQLI_BOTH);
    if (mysqli_num_rows($result) == 1)
        echo "Hello " . $username;
    else {
        echo "Login fail";
        include "login_view.php";
    }
?>