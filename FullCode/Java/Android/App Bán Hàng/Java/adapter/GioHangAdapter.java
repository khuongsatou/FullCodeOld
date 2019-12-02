package com.example.bestchikass3of2.adapter;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.bestchikass3of2.R;
import com.example.bestchikass3of2.activity.GioHangActivity;
import com.example.bestchikass3of2.activity.MainActivity;
import com.example.bestchikass3of2.model.GioHang;
import com.squareup.picasso.Picasso;

import java.text.DecimalFormat;
import java.util.ArrayList;

public class GioHangAdapter extends BaseAdapter {
    Context context;
    ArrayList<GioHang> gioHangArrayList;

    public GioHangAdapter(Context context, ArrayList<GioHang> gioHangArrayList) {
        this.context = context;
        this.gioHangArrayList = gioHangArrayList;
    }

    @Override
    public int getCount() {
        return gioHangArrayList.size();
    }

    @Override
    public Object getItem(int position) {
        return gioHangArrayList.get(position);
    }

    @Override
    public long getItemId(int position) {
        return position;
    }

    private class ViewHolder{
        TextView txtTenGioHang,txtGiaGioHang;
        ImageView imgGioHang;
        Button btnMinus , btnValues,btnPlus;
    }

    @Override
    public View getView(final int position, View convertView, ViewGroup parent) {
        final ViewHolder viewHolder;
        if (convertView == null){
            viewHolder = new ViewHolder();
            LayoutInflater layoutInflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            convertView = layoutInflater.inflate(R.layout.dong_gio_hang,null);
            viewHolder.imgGioHang =(ImageView) convertView.findViewById(R.id.imageViewGioHang);
            viewHolder.txtTenGioHang =(TextView) convertView.findViewById(R.id.textViewTenGioHang);
            viewHolder.txtGiaGioHang =(TextView) convertView.findViewById(R.id.textViewGiaGioHang);
            viewHolder.btnMinus =(Button) convertView.findViewById(R.id.buttonminus);
            viewHolder.btnValues =(Button) convertView.findViewById(R.id.buttonvalues);
            viewHolder.btnPlus =(Button) convertView.findViewById(R.id.buttonplus);
            convertView.setTag(viewHolder);
        }else{
            viewHolder = (ViewHolder) convertView.getTag();
        }

        GioHang gioHang = (GioHang) getItem(position);
        viewHolder.txtTenGioHang.setText(gioHang.getTensp());
        DecimalFormat decimalFormat = new DecimalFormat("###,###,###");
        viewHolder.txtGiaGioHang.setText("Giá : "+decimalFormat.format(gioHang.getGiasp())+" VND");
        Picasso.get().load(gioHang.getHinhsp())
                .placeholder(R.drawable.noimage)
                .error(R.drawable.error)
                .into(viewHolder.imgGioHang);
        viewHolder.btnValues.setText(gioHang.getSoluongsp()+"");

        int sl = Integer.parseInt(viewHolder.btnValues.getText().toString());
        if (sl>=10){
            viewHolder.btnMinus.setVisibility(View.VISIBLE);
            viewHolder.btnPlus.setVisibility(View.INVISIBLE);

        }else if (sl <= 1){
            viewHolder.btnMinus.setVisibility(View.INVISIBLE);
        } else if (sl >= 1){
            viewHolder.btnMinus.setVisibility(View.VISIBLE);
            viewHolder.btnPlus.setVisibility(View.VISIBLE);
        }

        viewHolder.btnPlus.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int slMoiNhat = Integer.parseInt(viewHolder.btnValues.getText().toString())+1;
                int slht = MainActivity.mangGioHang.get(position).getSoluongsp();
                long giaht = MainActivity.mangGioHang.get(position).getGiasp();
                MainActivity.mangGioHang.get(position).setSoluongsp(slMoiNhat);

                if (slht !=0){
                    long giamoinhat = (giaht * slMoiNhat) / slht;
                    MainActivity.mangGioHang.get(position).setGiasp(giamoinhat);
                    DecimalFormat decimalFormat = new DecimalFormat("###,###,###");
                    viewHolder.txtGiaGioHang.setText("Giá : "+decimalFormat.format(giamoinhat)+" VND");
                    GioHangActivity.EvenUltil();
                    if (slMoiNhat >9){
                        viewHolder.btnPlus.setVisibility(View.INVISIBLE);
                        viewHolder.btnMinus.setVisibility(View.VISIBLE);
                        viewHolder.btnValues.setText(String.valueOf(slMoiNhat));
                    }else{
                        viewHolder.btnPlus.setVisibility(View.VISIBLE);
                        viewHolder.btnMinus.setVisibility(View.VISIBLE);
                        viewHolder.btnValues.setText(String.valueOf(slMoiNhat));
                    }
                }



            }
        });

        viewHolder.btnMinus.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int slMoiNhat = Integer.parseInt(viewHolder.btnValues.getText().toString())-1;
                int slht = MainActivity.mangGioHang.get(position).getSoluongsp();
                long giaht = MainActivity.mangGioHang.get(position).getGiasp();
                MainActivity.mangGioHang.get(position).setSoluongsp(slMoiNhat);
                if (slht !=0 ){
                    long giamoinhat = (giaht * slMoiNhat)/slht;
                    MainActivity.mangGioHang.get(position).setGiasp(giamoinhat);
                    DecimalFormat decimalFormat = new DecimalFormat("###,###,###");
                    viewHolder.txtGiaGioHang.setText("Giá : "+decimalFormat.format(giamoinhat)+" VND");
                    GioHangActivity.EvenUltil();
                    if (slMoiNhat <2){
                        viewHolder.btnPlus.setVisibility(View.VISIBLE);
                        viewHolder.btnMinus.setVisibility(View.INVISIBLE);
                        viewHolder.btnValues.setText(String.valueOf(slMoiNhat));
                    }else{
                        viewHolder.btnPlus.setVisibility(View.VISIBLE);
                        viewHolder.btnMinus.setVisibility(View.VISIBLE);
                        viewHolder.btnValues.setText(String.valueOf(slMoiNhat));
                    }
                }


            }
        });

        return convertView;
    }
}
