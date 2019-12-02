package com.example.bestchikass3of2.activity;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Spinner;
import android.widget.TextView;

import com.android.volley.toolbox.StringRequest;
import com.example.bestchikass3of2.R;
import com.example.bestchikass3of2.model.GioHang;
import com.example.bestchikass3of2.model.SanPham;
import com.squareup.picasso.Picasso;

import org.w3c.dom.Text;

import java.text.DecimalFormat;

public class ChiTietSanPham extends AppCompatActivity {
    ImageView imgTenSanPham;
    TextView txtTenSanPham,txtGiaSanPham,txtMotaSanPham;
    Toolbar toolbar;
    Spinner spinner;
    Button btnDatMua;
    int id=0;
    String TenChiTiet ="";
    int GiaChiTiet =0;
    String HinhAnhChiTiet ="";
    String MotaChiTiet ="";
    int idSanPham =0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_chi_tiet_san_pham);

        AnhXa();
        ShowActionBar();
        GetInformation();
        CatchEventSpinner();
        EventButton();
    }

    private void EventButton() {
        btnDatMua.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (MainActivity.mangGioHang.size() >0){
                    int soluong = Integer.parseInt(spinner.getSelectedItem().toString());
                    boolean exists = false;
                    for(int i=0;i<MainActivity.mangGioHang.size();i++){
                        if (MainActivity.mangGioHang.get(i).getIdsp() == id){
                            MainActivity.mangGioHang.get(i).setSoluongsp(MainActivity.mangGioHang.get(i).getSoluongsp() + soluong );
                            if (MainActivity.mangGioHang.get(i).getSoluongsp()>=10){
                                MainActivity.mangGioHang.get(i).setSoluongsp(10);
                            }
                            MainActivity.mangGioHang.get(i).setGiasp(GiaChiTiet*MainActivity.mangGioHang.get(i).getSoluongsp());
                            exists = true;
                        }
                    }
                    if (exists ==false){
                        int sl = Integer.parseInt(spinner.getSelectedItem().toString());
                        long GiaMoi = soluong*GiaChiTiet;
                        MainActivity.mangGioHang.add(new GioHang(id,TenChiTiet,GiaMoi,HinhAnhChiTiet,sl));

                    }
                }else{
                    int soluong = Integer.parseInt(spinner.getSelectedItem().toString());
                    long GiaMoi = soluong*GiaChiTiet;
                    MainActivity.mangGioHang.add(new GioHang(id,TenChiTiet,GiaMoi,HinhAnhChiTiet,soluong));
                }
                Intent intent = new Intent(getApplicationContext(),GioHangActivity.class);
                startActivity(intent);

            }
        });
    }

    private void CatchEventSpinner() {
        Integer[] soluong = new Integer[]{1,2,3,4,5,6,7,8,9,10};
        ArrayAdapter<Integer> arrayAdapter = new ArrayAdapter<Integer>(this,android.R.layout.simple_spinner_dropdown_item,soluong);
        spinner.setAdapter(arrayAdapter);
    }

    private void GetInformation() {


        SanPham sanPham = (SanPham) getIntent().getSerializableExtra("thongtinsanpham");
        id = sanPham.getId();
        TenChiTiet = sanPham.getTensanpham();
        GiaChiTiet = sanPham.getGiasanpham();
        HinhAnhChiTiet = sanPham.getHinhAnhsanpham();
        MotaChiTiet = sanPham.getMoTasanpham();
        idSanPham = sanPham.getIdsanpham();

        txtTenSanPham.setText(TenChiTiet);
        DecimalFormat decimalFormat = new DecimalFormat("###,###,###");
        txtGiaSanPham.setText("Giá : "+decimalFormat.format(sanPham.getGiasanpham())+" VND");
        txtMotaSanPham.setText(MotaChiTiet);

        Picasso.get().load(HinhAnhChiTiet)
                .placeholder(R.drawable.noimage)
                .error(R.drawable.error)
                .into(imgTenSanPham);

    }

    private void ShowActionBar() {
        setSupportActionBar(toolbar);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });

    }

    private void AnhXa() {
        imgTenSanPham = (ImageView) findViewById(R.id.imageViewSanPhamCT);
        txtTenSanPham =(TextView) findViewById(R.id.textViewTenSanPhamCT);
        txtGiaSanPham =(TextView) findViewById(R.id.textViewGiaSanPhamCT);
        txtMotaSanPham =(TextView) findViewById(R.id.textViewMoTaSanPhamCT);
        toolbar =(Toolbar) findViewById(R.id.toolbarCTSanpham);
        spinner =(Spinner) findViewById(R.id.spinner);
        btnDatMua =(Button) findViewById(R.id.buttonDatMuaSanPhamCT);
    }
}
