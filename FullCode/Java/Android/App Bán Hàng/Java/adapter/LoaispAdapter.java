package com.example.bestchikass3of2.adapter;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.bestchikass3of2.R;
import com.example.bestchikass3of2.model.Loaisp;
import com.squareup.picasso.Picasso;

import java.util.ArrayList;

public class LoaispAdapter extends BaseAdapter {
    Context context;
    ArrayList<Loaisp> loaispArrayList;

    public LoaispAdapter(Context context, ArrayList<Loaisp> loaispArrayList) {
        this.context = context;
        this.loaispArrayList = loaispArrayList;
    }

    @Override
    public int getCount() {
        return loaispArrayList.size();
    }

    @Override
    public Object getItem(int position) {
        return loaispArrayList.get(position);
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }
    public class ViewHolder{
        TextView txtLoaiSP;
        ImageView imgLoaiSP;
    }
    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        ViewHolder viewHolder;
        if (convertView == null){
            viewHolder = new ViewHolder();
            LayoutInflater layoutInflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            convertView = layoutInflater.inflate(R.layout.dong_list_view_loaisp,null);
            viewHolder.txtLoaiSP = (TextView) convertView.findViewById(R.id.textViewLoaisp);
            viewHolder.imgLoaiSP =(ImageView) convertView.findViewById(R.id.imageViewLoaisp);
            convertView.setTag(viewHolder);
        }else {
            viewHolder = (ViewHolder) convertView.getTag();
        }

        Loaisp loaisp = (Loaisp) getItem(position);
        viewHolder.txtLoaiSP.setText(loaisp.getTenLoaisp());
        Picasso.get().load(loaisp.getHinhAnhsp())
                .placeholder(R.drawable.noimage)
                .error(R.drawable.error)
                .into(viewHolder.imgLoaiSP);


        return convertView;
    }




}
