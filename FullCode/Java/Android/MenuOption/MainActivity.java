package com.tttuan.baitapst2;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageButton;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if(item.getItemId()==R.id.dark_mode){
            ImageButton btnup =(ImageButton)findViewById(R.id.btnimgup);
            btnup.setBackgroundResource(R.drawable.btn_bg2);
            ImageButton btndown=(ImageButton)findViewById(R.id.btnimgdown);
            btndown.setBackgroundResource(R.drawable.btn_bg2);
            ImageButton btnup1 =(ImageButton)findViewById(R.id.btnimgup1);
            btnup.setBackgroundResource(R.drawable.btn_bg);
            ImageButton btndown1=(ImageButton)findViewById(R.id.btnimgdown1);
            btndown.setBackgroundResource(R.drawable.btn_bg);
        }
        else
        {
            ImageButton btnup =(ImageButton)findViewById(R.id.btnimgup);
            btnup.setBackgroundResource(R.drawable.btn_bg);
            ImageButton btndown=(ImageButton)findViewById(R.id.btnimgdown);
            btndown.setBackgroundResource(R.drawable.btn_bg);
            ImageButton btnup1 =(ImageButton)findViewById(R.id.btnimgup1);
            btnup.setBackgroundResource(R.drawable.btn_bg2);
            ImageButton btndown1=(ImageButton)findViewById(R.id.btnimgdown1);
            btndown.setBackgroundResource(R.drawable.btn_bg2);
        }
        return true;
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {

        getMenuInflater().inflate(R.menu.main_menu,menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void downscore(View view){
        TextView txt = null;
        switch (view.getId()){
            case R.id.btnimgdown:
            txt = (TextView)findViewById(R.id.txtscore);
            break;
            case R.id.btnimgdown1:
            txt = (TextView)findViewById(R.id.txtscore1);
        }
        int curPoint = Integer.parseInt(txt.getText().toString())-1;
        txt.setText(Integer.toString(curPoint));
    }
    public void upscore(View view){
        TextView txt = null;
        switch (view.getId()){
            case R.id.btnimgup:
                txt = (TextView)findViewById(R.id.txtscore);
                break;
            case R.id.btnimgup1:
                txt = (TextView)findViewById(R.id.txtscore1);
        }
        int curPoint = Integer.parseInt(txt.getText().toString())+1;
        txt.setText(Integer.toString(curPoint));
    }
}
