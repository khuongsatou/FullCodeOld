package com.example.bestchikass3of2.activity;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ListView;
import android.widget.Toolbar;

import com.example.bestchikass3of2.R;
import com.example.bestchikass3of2.adapter.DienThoaiAdapter;
import com.example.bestchikass3of2.model.SanPham;

import java.util.ArrayList;

public class ThongTinActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_thong_tin);

        AnhXa();
    }

    private void AnhXa() {

    }
}
