<?php
//xử lí database
function login($email, $pwd) {
    $pwd = md5($pwd);

    $host = 'localhost';
    $username = 'root';
    $pass = '';
    $db = 'onlineshopping';

    $conn = mysqli_connect($host,$username,$pass);
    mysqli_select_db($conn, $db);
    if (!$conn)
        die("Connection refused").mysql_connect_error();

    $email = mysqli_real_escape_string($conn, $email);
    $sql = "SELECT * FROM user_info WHERE email='$email' AND password='$pwd'";
    $run_query = mysqli_query($conn,$sql);

    if (mysqli_num_rows($run_query) == 1) {
        $row = mysqli_fetch_array($run_query);
        mysqli_close($conn);
        return true;
    }
    else {
        mysqli_close($conn);
        return false;
    }
}


?>