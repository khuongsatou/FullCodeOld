package com.tttuan.internetconnection;

import androidx.appcompat.app.AppCompatActivity;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import org.json.JSONException;
import org.json.JSONObject;

public class ManHinhChinhActvity extends AppCompatActivity {

    private String sharedPrefFile = "com.tttuan.internetconnection";
    private SharedPreferences mPreferences;
    private TextView mThongBao, mToken;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_man_hinh_chinh_actvity);

        mPreferences = getSharedPreferences(sharedPrefFile, MODE_PRIVATE);

        mThongBao = findViewById(R.id.thong_bao_text);
        mToken = findViewById(R.id.token_text);

        // Lay token trong Shared Preferences
        String token = mPreferences.getString("TOKEN", "");
        mToken.setText(token);
    }

    public void dangXuat(View view) {
        // Xoa token trong SharedPreferences
        SharedPreferences.Editor editor = mPreferences.edit();
        editor.clear();
        editor.apply();

        //Quay ve Activity Dang nhap???
    }

    public void goiAPI(View view) {

        String token = mPreferences.getString("TOKEN", null);

        new FectAPIToken(){
            @Override
            protected void onPostExecute(String s) {
                super.onPostExecute(s);
                try {
                    JSONObject jsonObject = new JSONObject(s);
                    mThongBao.setText(jsonObject.getString("message"));
                } catch (JSONException e) {
                    e.printStackTrace();
                }

            }
        }.execute("lay-thong-tin", "GET", token);

    }
}
