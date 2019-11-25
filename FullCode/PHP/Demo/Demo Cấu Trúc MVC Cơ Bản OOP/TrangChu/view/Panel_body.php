<?php 
								if($product_cat==1)
							{
	                            for ($i = 0; $i < count($Electronics); $i++) {
	                                echo '
	                                    <div class="col-md-4">
	                                        <div class="panel panel-info">
	                                            <div class="panel-heading">' . $Electronics[$i]->title . '</div>
									            <div class="panel-body"><img width="200px" height="250px" src="./../../assets/prod_images/' . $Electronics[$i]->image . '"></div>
	                                            <div class="panel-heading">
	                                                ' . $Electronics[$i]->price . '
									                <button class="btn btn-danger btn-xs" style="float:right;">Add to Cart</button>
									            </div>
								            </div>
							            </div>
	                                ';
	                            }
                        	}
                        	else if($product_cat==2)
                        	{
                        		for ($i = 0; $i < count($LadiesWear); $i++) {
	                                echo '
	                                    <div class="col-md-4">
	                                        <div class="panel panel-info">
	                                            <div class="panel-heading">' . $LadiesWear[$i]->title . '</div>
									            <div class="panel-body"><img width="200px" height="250px" src="./../../assets/prod_images/' . $LadiesWear[$i]->image . '"></div>
	                                            <div class="panel-heading">
	                                                ' . $LadiesWear[$i]->price . '
									                <button class="btn btn-danger btn-xs" style="float:right;">Add to Cart</button>
									            </div>
								            </div>
							            </div>
	                                ';
	                            }
                        	}
                        	else if($product_cat==3)
                        	{
                        		for ($i = 0; $i < count($MensWear); $i++) {
	                                echo '
	                                    <div class="col-md-4">
	                                        <div class="panel panel-info">
	                                            <div class="panel-heading">' . $MensWear[$i]->title . '</div>
									            <div class="panel-body"><img width="200px" height="250px" src="./../../assets/prod_images/' . $MensWear[$i]->image . '"></div>
	                                            <div class="panel-heading">
	                                                ' . $MensWear[$i]->price . '
									                <button class="btn btn-danger btn-xs" style="float:right;">Add to Cart</button>
									            </div>
								            </div>
							            </div>
	                                ';
	                            }
                        	}
                        	else if($product_cat==4)
                        	{
                        		for ($i = 0; $i < count($KidsWear); $i++) {
	                                echo '
	                                    <div class="col-md-4">
	                                        <div class="panel panel-info">
	                                            <div class="panel-heading">' . $KidsWear[$i]->title . '</div>
									            <div class="panel-body"><img width="200px" height="250px" src="./../../assets/prod_images/' . $KidsWear[$i]->image . '"></div>
	                                            <div class="panel-heading">
	                                                ' . $KidsWear[$i]->price . '
									                <button class="btn btn-danger btn-xs" style="float:right;">Add to Cart</button>
									            </div>
								            </div>
							            </div>
	                                ';
	                            }
                        	}
                        	else if($product_cat==5)
                        	{
                        		for ($i = 0; $i < count($HomeAppliances); $i++) {
	                                echo '
	                                    <div class="col-md-4">
	                                        <div class="panel panel-info">
	                                            <div class="panel-heading">' . $HomeAppliances[$i]->title . '</div>
									            <div class="panel-body"><img width="200px" height="250px" src="./../../assets/prod_images/' . $HomeAppliances[$i]->image . '"></div>
	                                            <div class="panel-heading">
	                                                ' . $HomeAppliances[$i]->price . '
									                <button class="btn btn-danger btn-xs" style="float:right;">Add to Cart</button>
									            </div>
								            </div>
							            </div>
	                                ';
	                            }
                        	}
                        	else if($product_cat==6)
                        	{
                        		for ($i = 0; $i < count($Sports); $i++) {
	                                echo '
	                                    <div class="col-md-4">
	                                        <div class="panel panel-info">
	                                            <div class="panel-heading">' . $Sports[$i]->title . '</div>
									            <div class="panel-body"><img width="200px" height="250px" src="./../../assets/prod_images/' . $Sports[$i]->image . '"></div>
	                                            <div class="panel-heading">
	                                                ' . $Sports[$i]->price . '
									                <button class="btn btn-danger btn-xs" style="float:right;">Add to Cart</button>
									            </div>
								            </div>
							            </div>
	                                ';
	                            }
                        	}
                        	else if (isset($_GET['product_cat']))
                        	{
                        		for ($i = 0; $i < count($products); $i++) {
	                                echo '
	                                    <div class="col-md-4">
	                                        <div class="panel panel-info">
	                                            <div class="panel-heading">' . $products[$i]->title . '</div>
									            <div class="panel-body"><img width="200px" height="250px" src="./../../assets/prod_images/' . $products[$i]->image . '"></div>
	                                            <div class="panel-heading">
	                                                ' . $products[$i]->price . '
									                <button class="btn btn-danger btn-xs" style="float:right;">Add to Cart</button>
									            </div>
								            </div>
							            </div>
	                                ';
	                            }
                        	}
 ?>
 <?php
 
 ?>


 <?php 
 		if (isset($_GET['product_brand'])) {
 			$products_brand_id = $_GET['product_brand'];
 			$result =getBrands_id($products_brand_id);
 			while ($row = mysqli_fetch_array($result)) {
 			     echo '<div class="col-md-4">
				            <div class="panel panel-info">
					            <div class="panel-heading">' . $row['product_title'] . '</div>
								<div class="panel-body"><img width="200px" height="250px" src="./../../assets/prod_images/'  .$row['product_image']. '"></div>
					            <div class="panel-heading">' . $row['product_price']. '<button class="btn btn-danger btn-xs" style="float:right;">Add to Cart</button>
								</div>
							 </div>
						</div>';
 			}
 		}


  ?>