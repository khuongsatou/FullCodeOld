package com.example.bestchikass3of2.activity;

import android.content.Intent;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.GridLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.AdapterView;
import android.widget.ImageView;
import android.widget.ListView;

import android.widget.Toast;
import android.widget.ViewFlipper;

import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;
import com.example.bestchikass3of2.R;
import com.example.bestchikass3of2.adapter.LoaispAdapter;
import com.example.bestchikass3of2.adapter.SanPhamAdapter;
import com.example.bestchikass3of2.model.GioHang;
import com.example.bestchikass3of2.model.Loaisp;
import com.example.bestchikass3of2.model.SanPham;
import com.example.bestchikass3of2.until.CheckConnection;
import com.example.bestchikass3of2.until.Server;
import com.squareup.picasso.Picasso;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    DrawerLayout drawerLayout;
    Toolbar toolbar;
    ViewFlipper viewFlipper;
    RecyclerView recyclerView;
    NavigationView navigationView;
    ListView lvLoaiSP;
    ArrayList<Loaisp> loaispArrayList;
    LoaispAdapter loaispAdapter;
    int id = 0;
    String tenloaisp = "";
    String hinhanhloaisp="";
    ArrayList<SanPham> sanPhamArrayList;
    SanPhamAdapter sanPhamAdapter;
    public static ArrayList<GioHang> mangGioHang;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        AnhXa();
        ShowActionBar();
        ActionViewFlipper();
        GetDuLieuLoaiSP();
        GetDuLieuMoiNhat();
        CatchOnItemListView();
    }

    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_gio_hang,menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.menuGioHang:
                Intent intent = new Intent(getApplicationContext(),GioHangActivity.class);
                startActivity(intent);
        }
        return super.onOptionsItemSelected(item);
}

    private void CatchOnItemListView() {
        lvLoaiSP.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                switch (position){
                    case 0:
                        startActivity(new Intent(MainActivity.this,MainActivity.class));
                        drawerLayout.closeDrawer(GravityCompat.START);
                        break;
                    case 1:
                    {
                        Intent intent = new Intent(MainActivity.this,DienThoaiActivity.class);
                        intent.putExtra("idLoaiSanPham",loaispArrayList.get(position).getId());
                        startActivity(intent);
                        break;
                    }

                    case 2:
                    {
                        Intent intent = new Intent(MainActivity.this,LaptopActivity.class);
                        intent.putExtra("idLoaiSanPham",loaispArrayList.get(position).getId());
                        startActivity(intent);
                        break;
                    }
                    case 3:
                    {
                        Intent intent = new Intent(MainActivity.this,LienHeActivity.class);
                         startActivity(intent);
                        break;
                    }
                    case 4:
                    {
                        Intent intent = new Intent(MainActivity.this,ThongTinActivity.class);
                        startActivity(intent);
                        break;
                    }

                }
            }
        });
    }

    private void GetDuLieuMoiNhat() {
        RequestQueue requestQueue = Volley.newRequestQueue(getApplicationContext());
        JsonArrayRequest jsonArrayRequest = new JsonArrayRequest(Server.DuongDanSPMoiNhat,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        if (response != null){
                            int ID = 0;
                            String Tensanpham ="";
                            Integer Giasanpham = 0;
                            String HinhAnhsanpham="";
                            String MoTasanpham ="";
                            int IDsanpham = 0;
                            for (int i=0;i<response.length();i++){
                                try {
                                    JSONObject jsonObject = response.getJSONObject(i);
                                    ID = jsonObject.getInt("id");
                                    Tensanpham = jsonObject.getString("tensp");
                                    Giasanpham = jsonObject.getInt("giasp");
                                    HinhAnhsanpham = jsonObject.getString("hinhanhsp");
                                    MoTasanpham = jsonObject.getString("motasp");
                                    IDsanpham = jsonObject.getInt("idsanpham");
                                    sanPhamArrayList.add(new SanPham(ID,Tensanpham,Giasanpham,HinhAnhsanpham,MoTasanpham,IDsanpham));


                                } catch (JSONException e) {
                                    e.printStackTrace();
                                }

                            }
                            sanPhamAdapter.notifyDataSetChanged();
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {

                    }
                }
        );
        requestQueue.add(jsonArrayRequest);
    }

    private void GetDuLieuLoaiSP() {
        RequestQueue requestQueue = Volley.newRequestQueue(getApplicationContext());
        final JsonArrayRequest jsonArrayRequest = new JsonArrayRequest(Server.DuongDanLoaiSP,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        if(response !=null){
                            for (int i=0; i<response.length();i++){
                                try {
                                    JSONObject jsonObject = response.getJSONObject(i);
                                    id              = jsonObject.getInt("id");
                                    tenloaisp       = jsonObject.getString("tenloaisp");
                                    hinhanhloaisp   = jsonObject.getString("hinhanhloaisp");
                                    loaispArrayList.add(new Loaisp(id,tenloaisp,hinhanhloaisp));
                                    loaispAdapter.notifyDataSetChanged();
                                } catch (JSONException e) {
                                    e.printStackTrace();
                                }
                            }
                            loaispArrayList.add(3,new Loaisp(0,"Liên Hệ","https://images2-focus-opensocial.googleusercontent.com/gadgets/proxy?container=focus&gadget=a&no_expand=1&refresh=604800&url=http://animehay.tv/uploads/images/2019/01/go-toubun-no-hanayome-cover.jpg"));
                            loaispArrayList.add(4,new Loaisp(0,"Thông Tin","https://images2-focus-opensocial.googleusercontent.com/gadgets/proxy?container=focus&gadget=a&no_expand=1&refresh=604800&url=http://animehay.tv/uploads/images/2019/01/go-toubun-no-hanayome-cover.jpg"));
                            loaispAdapter.notifyDataSetChanged();
                        }


                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        CheckConnection.ShowToast_Short(getApplicationContext(),"Lỗi");
                    }
                }
        );
        requestQueue.add(jsonArrayRequest);
    }

    private void ActionViewFlipper() {


        ArrayList<String> mangQuangCao = new ArrayList<>();
        mangQuangCao.add("https://images2-focus-opensocial.googleusercontent.com/gadgets/proxy?container=focus&gadget=a&no_expand=1&refresh=604800&url=http://animehay.tv/uploads/images/2019/01/go-toubun-no-hanayome-cover.jpg");
        mangQuangCao.add("https://images2-focus-opensocial.googleusercontent.com/gadgets/proxy?container=focus&gadget=a&no_expand=1&refresh=604800&url=http://animehay.tv/uploads/images/2019/01/grimms-notes-the-animation-cover.jpg");
        mangQuangCao.add("https://images2-focus-opensocial.googleusercontent.com/gadgets/proxy?container=focus&gadget=a&no_expand=1&refresh=604800&url=http://animehay.tv/uploads/images/2019/01/tate-no-yuusha-no-nariagari-cover-1545741702.jpg");
        mangQuangCao.add("https://images2-focus-opensocial.googleusercontent.com/gadgets/proxy?container=focus&gadget=a&no_expand=1&refresh=604800&url=http://animehay.tv/uploads/images/2018/12/manaria-friends-cover.jpg");
        for (int i=0;i<mangQuangCao.size();i++){
            ImageView imageView = new ImageView(getApplicationContext());
            Picasso.get().load(mangQuangCao.get(i)).into(imageView);
            imageView.setScaleType(ImageView.ScaleType.FIT_XY);
            viewFlipper.addView(imageView);
        }
        viewFlipper.setFlipInterval(5000);
        viewFlipper.setAutoStart(true);

        Animation animation_slide_in = AnimationUtils.loadAnimation(getApplicationContext(),R.anim.anim_in_left);
        Animation animation_slide_out = AnimationUtils.loadAnimation(getApplicationContext(),R.anim.anim_out_left);

        viewFlipper.setInAnimation(animation_slide_in);
        viewFlipper.setOutAnimation(animation_slide_out);

    }

    private void ShowActionBar() {
        setSupportActionBar(toolbar);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        toolbar.setNavigationIcon(android.R.drawable.ic_menu_sort_by_size);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                drawerLayout.openDrawer(GravityCompat.START);
            }
        });

    }

    private void AnhXa() {
        drawerLayout = (DrawerLayout) findViewById(R.id.drawerLayout);
        toolbar =(Toolbar) findViewById(R.id.toolBar);
        viewFlipper =(ViewFlipper) findViewById(R.id.viewFlipper);
        recyclerView =(RecyclerView) findViewById(R.id.recyclerView);
        navigationView =(NavigationView) findViewById(R.id.navigationView);
        lvLoaiSP =(ListView) findViewById(R.id.listViewLoaiSP);
        loaispArrayList = new ArrayList<>();
        loaispArrayList.add(0,new Loaisp(0,"Trang Chính","https://images2-focus-opensocial.googleusercontent.com/gadgets/proxy?container=focus&gadget=a&no_expand=1&refresh=604800&url=http://animehay.tv/uploads/images/2019/01/go-toubun-no-hanayome-cover.jpg"));

        loaispAdapter = new LoaispAdapter(getApplicationContext(),loaispArrayList);
        lvLoaiSP.setAdapter(loaispAdapter);

        sanPhamArrayList = new ArrayList<>();
        sanPhamAdapter =new SanPhamAdapter(getApplicationContext(),sanPhamArrayList);
        recyclerView.setHasFixedSize(true);
        recyclerView.setLayoutManager(new GridLayoutManager(getApplicationContext(),2));
        recyclerView.setAdapter(sanPhamAdapter);

        if (mangGioHang !=null){

        }else{
            mangGioHang = new ArrayList<>();
        }
    }
}
