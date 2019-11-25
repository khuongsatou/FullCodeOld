<?php require "data.php"; ?>
<div class="header">
  <h1>
      <?php
        echo $title;
      ?>
  </h1>
  <p><?php echo $sub_title?></p>
</div>

<div class="topnav">
    <?php
        for ($i = 0; $i < sizeof($menu) - 1; $i++) {
            echo '<a href="#">' . $menu[$i] . '</a>';
        }
        echo '<a href="#" style="float:right">' . $menu[sizeof($menu) - 1] .'</a>';
    ?>
</div>