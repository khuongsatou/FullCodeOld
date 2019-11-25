 <?php 
       	//signup
        if (isset($_POST['action'])) {
            $data  = array();
            $data['f_name']   = isset($_POST['f_name'])     ? $_POST['f_name']      : '';
            $data['l_name']   = isset($_POST['l_name'])     ? $_POST['l_name']      : '';
            $data['email']    = isset($_POST['email'])      ? $_POST['email']       : '';
            $data['password'] = isset($_POST['password'])   ? $_POST['password']    : '';
            $data['mobile']   = isset($_POST['mobile'])     ? $_POST['mobile']      : '';
            $data['address1'] = isset($_POST['address1'])   ? $_POST['address1']    : '';
            $data['address2'] = isset($_POST['address2'])   ? $_POST['address2']    : '';
            if (empty($data['f_name']) || empty($data['l_name']) || empty($data['email'])  || empty($data['password']) || empty($data['mobile']) || empty($data['address1']) || empty($data['address2']))
            {
                $error = Fill_Form_View();
                require 'register_view.php';
            }else{
                $flag= true;//reset
                if (!Check_FistName($data['f_name'])) {
                    $error = Fist_Error($data['f_name']);
                    $flag  = false;
                    require 'register_view.php';
                }
                if (!Check_LastName($data['l_name'])) {
                    $error=Last_Error($data['l_name']);
                    $flag= false;
                    require 'register_view.php';
                }
                if (!Check_Email($data['email'])) {
                    $error=Email_Error($data['email']);
                    $flag= false;
                    require 'register_view.php';
                }
                if (!Check_PassWord($data['password'])) {
                    $error=PassWord_Error();
                    $flag= false;
                    require 'register_view.php';
                }
                if (!Check_Mobile($data['mobile'])) {
                    $error=Mobile_Error($data['mobile']);
                    $flag= false;
                    require 'register_view.php';
                }
                if ($flag) {
                    $check = false;
                    for ($i = 0; $i < count($user_info) ; $i++) {
                        if ($data['email'] == $user_info[$i]->email) {
                            $check = true;
                            break;   
                        }
                    }
                    if ($check) {
                            echo 'account đã tồn tại';
?>

                        <form action="." method="POST">
                            <input type="hidden" value="register_view" name="action">
                            <input type="submit" value="Trở về">
                        </form> 


<?php       
                    }else{


                             // Fix lỗi ID
                            $luu_id =0;
                            $isCheck = false;
                            $data['user_id'] =null;
                            for ($i = 0; $i < count($user_info); $i++) {
                                if ($user_info[$i]->user_id != ($i+1)) {
                                    $luu_id = ($i+1);
                                    $isCheck= true;
                                    break;
                                }
                            }
                            if ($isCheck) {
                                $data['user_id'] = $luu_id;

                            }else{
                                $data['user_id'] = count($user_info)+1;//lấy toàn bộ id cart
                            }

                            //Tính sao với user đây nếu xóa bất kì thì nó sẽ Lỗi 
                            $data['password'] = MaHoaMD5PassWord($data['password']);
                            $user_info_m->Insert_user_info($data['user_id'],$data['f_name'],$data['l_name'],$data['email'],$data['password'],$data['mobile'],$data['address1'],$data['address2']);
                            echo 'Đăng kí thành công';
?>
                         <form action="." method="POST">
                            <input type="hidden" value="register_view" name="action">
                            <input type="submit" value="Trở về">
                        </form> 
<?php                            
                    }
                }

            }
        }

  ?>