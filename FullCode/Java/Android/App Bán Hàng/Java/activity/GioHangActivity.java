package com.example.bestchikass3of2.activity;

import android.content.DialogInterface;
import android.content.Intent;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;

import com.example.bestchikass3of2.R;
import com.example.bestchikass3of2.adapter.GioHangAdapter;
import com.example.bestchikass3of2.model.GioHang;
import com.example.bestchikass3of2.until.CheckConnection;

import java.text.DecimalFormat;
import java.util.ArrayList;

public class GioHangActivity extends AppCompatActivity {
    Toolbar tbGioHang;
    ListView lvGioHang;
    TextView txtThongBao;
    static TextView txtGiaTien;
    Button btnThanhToanGioHang,btnTiepTucMuaHang;
    GioHangAdapter gioHangAdapter;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_gio_hang);

        AnhXa();
        ActionToolBar();
        CheckData();
        EvenUltil();
        CatchOnItemListView();
        EventButton();
    }

    private void EventButton() {
        btnTiepTucMuaHang.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(getApplicationContext(),MainActivity.class));
            }
        });
        btnThanhToanGioHang.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (MainActivity.mangGioHang.size() >0){
                    startActivity(new Intent(getApplicationContext(),ThongTinKhachHangActivity.class));
                }else{
                    CheckConnection.ShowToast_Short(getApplicationContext(),"Giỏ Hàng chưa có sản phẩm");
                }
            }
        });
    }

    private void CatchOnItemListView() {
        lvGioHang.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> parent, View view, final int position, long id) {
                AlertDialog.Builder builder = new AlertDialog.Builder(GioHangActivity.this);
                builder.setTitle("Xác nhận xóa sản phẩm");
                builder.setMessage("Bạn có chắc muốn xóa sản phẩm này");
                builder.setPositiveButton("Có", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        if (MainActivity.mangGioHang.size() <= 0){
                            txtThongBao.setVisibility(View.VISIBLE);
                        }else{
                            MainActivity.mangGioHang.remove(position);
                            gioHangAdapter.notifyDataSetChanged();
                            EvenUltil();
                            if (MainActivity.mangGioHang.size() <= 0){
                                txtThongBao.setVisibility(View.VISIBLE);
                            }else{
                                txtThongBao.setVisibility(View.INVISIBLE);
                                gioHangAdapter.notifyDataSetChanged();
                                EvenUltil();
                            }
                        }
                    }
                });
                builder.setNegativeButton("Không", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        gioHangAdapter.notifyDataSetChanged();
                        EvenUltil();
                    }
                });
                builder.show();
                return true;
            }
        });
    }

    public static void EvenUltil() {
        long TongTien = 0;
        for (int i=0 ;i<MainActivity.mangGioHang.size();i++){
            TongTien += MainActivity.mangGioHang.get(i).getGiasp();
        }
        DecimalFormat decimalFormat = new DecimalFormat("###,###,###");
        txtGiaTien.setText(decimalFormat.format(TongTien)+" VND");

    }


    private void CheckData() {
        if (MainActivity.mangGioHang.size() <= 0){
            gioHangAdapter.notifyDataSetChanged();
            txtThongBao.setVisibility(View.VISIBLE);
            lvGioHang.setVisibility(View.INVISIBLE);
        }else{
            gioHangAdapter.notifyDataSetChanged();
            txtThongBao.setVisibility(View.INVISIBLE);
            lvGioHang.setVisibility(View.VISIBLE);
        }
    }

    private void ActionToolBar() {
        setSupportActionBar(tbGioHang);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        tbGioHang.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
    }

    private void AnhXa() {
        tbGioHang=(Toolbar) findViewById(R.id.toolBarGioHang);
        lvGioHang =(ListView) findViewById(R.id.listViewGioHang);
        txtThongBao =(TextView) findViewById(R.id.textViewThongBao);
        txtGiaTien =(TextView) findViewById(R.id.textViewGiaTien);
        btnThanhToanGioHang=(Button) findViewById(R.id.buttonThanhToanGioHang);
        btnTiepTucMuaHang =(Button) findViewById(R.id.buttonTiepTucMuaHang);

        gioHangAdapter = new GioHangAdapter(getApplicationContext(),MainActivity.mangGioHang);
        lvGioHang.setAdapter(gioHangAdapter);
    }
}
