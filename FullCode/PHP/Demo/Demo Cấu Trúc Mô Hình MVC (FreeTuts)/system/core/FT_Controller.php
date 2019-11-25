<?php if (!defined('PATH_SYSTEM'))die('Bad requested!');
	/**
	 * Nguyễn Văn Khương
	 * 
	 */
	class FT_Controller
	{
	    /**
	     * File Giao Tiếp Với DB
	     * Và Trả Về Cho View
	     */
	    protected $view 	= NULL;
	    protected $model 	= NULL;
	    protected $library 	= NULL;
	    protected $helper 	= NULL;
	    protected $config 	= NULL;
	    public function __construct($is_controller = true)
	    {
	        
	    }

	    



	     /**
	     * Chạy Application
	     * Truyền 2 tham số
	     */
	     // public function load($controller,$action)
	     // {
	     // 	//định dạng là {NAME}_Controller
	     // 	$controller = ucfirst(strtolower($controller)) . '_Controller';
	     // 	//định dạng là {Name}Action
	     // 	$action = strtolower($action) . 'Action';
	     // 	//kiểm tra
	     // 	if (!file_exists(PATH_APPLICATION . '/controller/' . $controller . '.php')) {
	     // 		die('Controller Không Tồn tại');
	     // 	}
	     // 	require_once PATH_APPLICATION.'/controller/'.$controller.'.php';
	     	
	     // 	//Kiểm tra class controller có tồn tại hay không.
	     // 	if (!class_exists($controller)) {
	     // 		die(' Controller không tồn tại');
	     // 	}
	     // 	//khởi tạo controller
	     // 	$controllerObject = new $controller();
	     // 	if (!method_exists($controllerObject, $action)) {
	     // 		die(' Action Không tồn tại');
	     // 	}
	     // 	//Gọi tới action
	     // 	$controllerObject->{$action}();
	     // }

	}

 ?>