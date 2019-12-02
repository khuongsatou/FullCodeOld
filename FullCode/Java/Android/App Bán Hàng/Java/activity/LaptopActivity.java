package com.example.bestchikass3of2.activity;

import android.content.Intent;
import android.os.Handler;
import android.os.Message;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.AbsListView;
import android.widget.AdapterView;
import android.widget.ListView;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.example.bestchikass3of2.R;
import com.example.bestchikass3of2.adapter.DienThoaiAdapter;
import com.example.bestchikass3of2.adapter.LapTopAdapter;
import com.example.bestchikass3of2.model.SanPham;
import com.example.bestchikass3of2.until.CheckConnection;
import com.example.bestchikass3of2.until.Server;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

public class LaptopActivity extends AppCompatActivity {
    Toolbar toolbar;
    ListView lvdt;
    LapTopAdapter laptopAdapter;
    ArrayList<SanPham> arrayListLaptop;
    int idLT =0;
    int page =1;
    View FooterView;
    Boolean isLoading = false;
    nHandler handler;
    Boolean limitData = false;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_laptop);

        AnhXa();
        getIdLoaiSP();
        ActionToolBar();
        GetData(page);
        LoadMoreData();

    }
    private void LoadMoreData() {
        lvdt.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Intent intent = new Intent(getApplicationContext(),ChiTietSanPham.class);
                intent.putExtra("thongtinsanpham",arrayListLaptop.get(position));
                startActivity(intent);
            }
        });

        lvdt.setOnScrollListener(new AbsListView.OnScrollListener() {
            @Override
            public void onScrollStateChanged(AbsListView view, int scrollState) {

            }

            @Override
            public void onScroll(AbsListView view, int firstVisibleItem, int visibleItemCount, int totalItemCount) {
                if (firstVisibleItem + visibleItemCount == totalItemCount && totalItemCount !=0 && isLoading == false && limitData == false){
                    isLoading = true;
                    ThreadData threadData = new ThreadData();
                    threadData.start();

                }
            }
        });
    }


    private void ActionToolBar() {
        setSupportActionBar(toolbar);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
    }
    private void GetData(int Page) {
        RequestQueue requestQueue = Volley.newRequestQueue(getApplicationContext());
        String duongdan = Server.DuongDanDienThoai+String.valueOf(Page);
        StringRequest stringRequest = new StringRequest(Request.Method.POST,
                duongdan,
                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {
                        int id=0;
                        String Tendt="";
                        int Giadt = 0;
                        String Hinhanhdt ="";
                        String Mota ="";
                        int idsplt =0;
                        if (response != null && response.length() != 2){
                            lvdt.removeFooterView(FooterView);
                            try {
                                JSONArray jsonArray = new JSONArray(response);
                                for (int i=0;i<jsonArray.length();i++){
                                    JSONObject jsonObject = jsonArray.getJSONObject(i);
                                    id = jsonObject.getInt("id");
                                    Tendt  = jsonObject.getString("tensp");
                                    Giadt = jsonObject.getInt("giasp");
                                    Hinhanhdt = jsonObject.getString("hinhanhsp");
                                    Mota = jsonObject.getString("motasp");
                                    idsplt = jsonObject.getInt("idsanpham");
                                    arrayListLaptop.add(new SanPham(id,Tendt,Giadt,Hinhanhdt,Mota,idsplt));

                                }
                                laptopAdapter.notifyDataSetChanged();

                            } catch (JSONException e) {
                                e.printStackTrace();
                            }
                        }else {
                            limitData = true;
                            lvdt.removeFooterView(FooterView);
                            CheckConnection.ShowToast_Short(getApplicationContext(),"Hết Dữ Liệu");

                        }
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
                HashMap<String,String> param = new HashMap<String,String>();
                param.put("idsanpham",String.valueOf(idLT));

                return param;
            }
        };
        requestQueue.add(stringRequest);
    }


    private void getIdLoaiSP() {
        idLT = getIntent().getIntExtra("idLoaiSanPham",-1);
        Log.d("giatriloaisanpham",idLT+"");
    }


    private void AnhXa() {
        toolbar =(Toolbar) findViewById(R.id.toolBarLapTop);
        lvdt =(ListView) findViewById(R.id.listViewLapTop);
        arrayListLaptop =new ArrayList<>();
        laptopAdapter = new LapTopAdapter(getApplicationContext(),arrayListLaptop);
        lvdt.setAdapter(laptopAdapter);
        LayoutInflater inflater = (LayoutInflater) getSystemService(LAYOUT_INFLATER_SERVICE);
        FooterView = inflater.inflate(R.layout.progressbar,null);
        handler = new nHandler();
    }


    public class nHandler extends Handler {
        @Override
        public void handleMessage(Message msg) {
            switch (msg.what){
                case 0:
                    lvdt.addFooterView(FooterView);
                    break;
                case 1:
                    GetData(++page);
                    isLoading = false;
                    break;

            }

            super.handleMessage(msg);
        }
    }

    public class ThreadData extends Thread{
        @Override
        public void run() {
            handler.sendEmptyMessage(0);
            try {
                Thread.sleep(3000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }

            Message message = handler.obtainMessage(1);
            handler.sendMessage(message);

            super.run();
        }
    }
}
