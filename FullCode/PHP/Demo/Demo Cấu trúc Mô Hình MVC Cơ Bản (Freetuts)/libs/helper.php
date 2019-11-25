 <?php 
 	//thư viện kiểm tra nhập và di chuyển
 	function base_url($uri='')
 	{
 		return 'http://localhost/mvcbasic/'.$uri;
 	}

 	function redirect($url)
 	{
 		header("location:{$url}");
 		exit();
 	}
 	function input_post($key)
 	{
 		return isset($_POST[$key]) ? trim($_POST[$key]) : false;
 	}

 	function input_get($key)
 	{
 		return isset($_GET[$key]) ? trim($_GET[$key]) : false;
 	}

 	function is_submit($key)
 	{
 		return isset($_POST['request_name']) && isset($_POST['request_name'])==$key;
 	}

 	function show_error($error,$key)
 	{
 		echo '<span style="color:red;">';
 		echo empty($error[$key]) ? "" : $error[$key];
 		echo '</span>';
 	}

 	function create_link($uri,$filter = array())
 	{
 		$string = '';
 		foreach ($filter as $key => $value) {
 			if ($value != '') {
 				$string .="&{$key}={$value}";
 			}
 		}
 		return $uri.($string ? '?'.ltrim($string,'&') : '');
 	}

 	function paging($link,$total_records,$current_page,$limit)
 	{
 		$total_page = ceil($total_records / $limit);
 		if ($current_page > $total_page) {
 			$current_page = $total_page;
 		}else if($current_page < 1){
 			$current_page =1;
 		}

 		$start = ($current_page -1 ) * $limit;
 		$html ='';

 		if ($current_page > 1 && $total_page > 1) {
 			 $html .= '<a href="'.str_replace('{page}',$current_page-1, $link).'">Prev</a>';
 		}

 		for ($i = 1; $i <=$total_page ; $i++) {
 			if ($i == $current_page) {
 				$html.='<span>'.$i.'</span>';
 			}else{
 				 $html .= '<a href="'.str_replace('{page}',$i, $link).'">'.$i.'</a>';
 			}
 		}

 		if ($current_page < $total_page && $total_page > 1) {
 			 $html .= '<a href="'.str_replace('{page}',$current_page+1, $link).'">Next</a>';
 		}

 		return array(
 			'start' => $start,
 			'limit' => $limit,
 			'html'  => $html
 		);

 	}


  ?>
