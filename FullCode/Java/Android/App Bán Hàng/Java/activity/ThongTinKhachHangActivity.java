package com.example.bestchikass3of2.activity;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.example.bestchikass3of2.R;
import com.example.bestchikass3of2.until.CheckConnection;
import com.example.bestchikass3of2.until.Server;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.HashMap;
import java.util.Map;

public class ThongTinKhachHangActivity extends AppCompatActivity {
    EditText edtTenKhachHang,edtEmail,edtSDT;
    Button btnXacNhan,btnTroVe;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_thong_tin_khach_hang);
        AnhXa();
        btnTroVe.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
        btnXacNhan.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                EventButton();
            }
        });
    }

    private void EventButton() {
        final String ten = edtTenKhachHang.getText().toString().trim();
        final String sdt = edtSDT.getText().toString().trim();
        final String email= edtEmail.getText().toString().trim();
        if (ten.isEmpty() && sdt.isEmpty() && email.isEmpty()){
            CheckConnection.ShowToast_Short(getApplicationContext(),"Bạn chưa nhập gì");
        }else{
            RequestQueue requestQueue1 = Volley.newRequestQueue(getApplicationContext());
            StringRequest stringRequest1 = new StringRequest(Request.Method.POST, Server.DuongDanDonHang,
                    new Response.Listener<String>() {
                        @Override
                        public void onResponse(final String madonHang) {
                            Log.d("madonhang",madonHang);
                                RequestQueue requestQueue = Volley.newRequestQueue(getApplicationContext());
                                StringRequest stringRequest = new StringRequest(Request.Method.POST, Server.DuongDanChiTietDonHang,
                                        new Response.Listener<String>() {
                                            @Override
                                            public void onResponse(String response) {
                                                if (response.equals("1")){
                                                    MainActivity.mangGioHang.clear();
                                                    CheckConnection.ShowToast_Short(getApplicationContext(),"Bạn đã thêm thành công");
                                                    startActivity(new Intent(getApplicationContext(),MainActivity.class));
                                                }
                                            }
                                        },
                                        new Response.ErrorListener() {
                                            @Override
                                            public void onErrorResponse(VolleyError error) {
                                                CheckConnection.ShowToast_Short(getApplicationContext(),"LỖI rq");
                                            }
                                        }
                                ){
                                    @Override
                                    protected Map<String, String> getParams() throws AuthFailureError {
                                        JSONArray jsonArray = new JSONArray();
                                        for (int i=0;i<MainActivity.mangGioHang.size();i++){
                                            JSONObject jsonObject = new JSONObject();
                                            try {
                                                jsonObject.put("madonhang",madonHang);
                                                jsonObject.put("masanpham",MainActivity.mangGioHang.get(i).getIdsp());
                                                jsonObject.put("tensanpham",MainActivity.mangGioHang.get(i).getTensp());
                                                jsonObject.put("giasanpham",MainActivity.mangGioHang.get(i).getGiasp());
                                                jsonObject.put("soluongsanpham",MainActivity.mangGioHang.get(i).getSoluongsp());
                                            } catch (JSONException e) {
                                                e.printStackTrace();
                                            }
                                            jsonArray.put(jsonObject);

                                        }
                                        HashMap<String,String> hashMap = new HashMap<String,String>();
                                        hashMap.put("json",jsonArray.toString());
                                        return hashMap;
                                    }
                                };
                                requestQueue.add(stringRequest);
                        }
                    },
                    new Response.ErrorListener() {
                        @Override
                        public void onErrorResponse(VolleyError error) {

                        }
                    }
            ){
                @Override
                protected Map<String, String> getParams() throws AuthFailureError {
                    HashMap<String,String> hashMap = new HashMap<String,String>();
                    hashMap.put("tenkhachhang",ten);
                    hashMap.put("sodienthoai",sdt);
                    hashMap.put("email",email);
                    return hashMap;
                }
            };
            requestQueue1.add(stringRequest1);
        }
    }

    private void AnhXa() {
        edtTenKhachHang = (EditText) findViewById(R.id.editTextTenKhachHang);
        edtEmail        = (EditText) findViewById(R.id.editTextEmail);
        edtSDT          = (EditText) findViewById(R.id.editTextSoDienThoai);
        btnXacNhan      = (Button)   findViewById(R.id.buttonXacNhan);
        btnTroVe        = (Button)   findViewById(R.id.buttonTroVe);
    }
}
