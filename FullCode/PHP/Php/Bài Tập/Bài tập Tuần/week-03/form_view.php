<?php 
    if (isset($error)) {
        echo "<p style='color: red'>$error</p>";
    }
?>

<form action="form_command.php" method="post">
    Username (*) <input type="text" name="username"><br>
    Email (*) <input type="text" name="email"><br>
    <input type="submit">
</form>