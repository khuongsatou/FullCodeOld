package com.tttuan.internetconnection;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import org.json.JSONException;
import org.json.JSONObject;

public class DangNhapActivity extends AppCompatActivity {

    private SharedPreferences mPref;
    private String sharedPrefFile = "com.tttuan.internetconnection";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dang_nhap);

        mPref = getSharedPreferences(sharedPrefFile, MODE_PRIVATE);

        // Kiem tra token trong Shared Preferences
        // Neu co token thi chuyen qua Man Hinh Chinh
        String token = mPref.getString("TOKEN", null);
        if(token != null) {
            // Mo activity Man Hinh Chinh
            Intent intent = new Intent(this, ManHinhChinhActvity.class);
            startActivity(intent);
        }
    }

    public void dangNhap(View view) {
        EditText mTenDangNhap = findViewById(R.id.ten_dang_nhap_text);
        EditText mMatKhau = findViewById(R.id.mat_khau_text);

        ConnectivityManager connMgr = (ConnectivityManager) getSystemService(Context.CONNECTIVITY_SERVICE);
        NetworkInfo networkInfo = null;

        if (connMgr != null) {
            networkInfo = connMgr.getActiveNetworkInfo();
        }

        if (networkInfo != null && networkInfo.isConnected()) {
            new FectDangNhap(){
                @Override
                protected void onPostExecute(String s) {
                    super.onPostExecute(s);
                    try {
                        JSONObject jsonObject = new JSONObject(s);
                        // Lay gia tri cua key "success"
                        boolean success = jsonObject.getBoolean("success");
                        String message = jsonObject.getString("message");
                        if(success) {
                            // Luu token vao Shared Preferences
                            String token = jsonObject.getString("token");

                            SharedPreferences.Editor editor = mPref.edit();
                            editor.putString("TOKEN", token);
                            editor.apply();

                            // Mo activity Man Hinh Chinh
                            Intent intent = new Intent(DangNhapActivity.this, ManHinhChinhActvity.class);
                            startActivity(intent);
                        } else {
                            Toast.makeText(DangNhapActivity.this, message, Toast.LENGTH_SHORT).show();
                        }

                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                }
            }.execute("dang-nhap", "POST", mTenDangNhap.getText().toString(), mMatKhau.getText().toString());

        } else {
            Toast.makeText(this, "Khong the ket noi den server", Toast.LENGTH_SHORT).show();
        }
    }
}
