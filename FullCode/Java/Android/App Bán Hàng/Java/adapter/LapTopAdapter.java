package com.example.bestchikass3of2.adapter;

import android.content.Context;
import android.text.TextUtils;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.bestchikass3of2.R;
import com.example.bestchikass3of2.model.SanPham;
import com.squareup.picasso.Picasso;

import java.text.DecimalFormat;
import java.util.ArrayList;

public class LapTopAdapter extends BaseAdapter {
    Context context;
    ArrayList<SanPham> sanPhamArrayList;

    public LapTopAdapter(Context context, ArrayList<SanPham> sanPhamArrayList) {
        this.context = context;
        this.sanPhamArrayList = sanPhamArrayList;
    }

    @Override
    public int getCount() {
        return sanPhamArrayList.size();
    }

    @Override
    public Object getItem(int position) {
        return sanPhamArrayList.get(position);
    }

    @Override
    public long getItemId(int position) {
        return position;
    }
    public class ViewHolder{
        ImageView imgLaptop;
        TextView txtTenLaptop,txtGiaLaptop,txtMoTaLaptop;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        ViewHolder viewHolder;
        if (convertView == null){
            viewHolder = new ViewHolder();
            LayoutInflater layoutInflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            convertView = layoutInflater.inflate(R.layout.dong_laptop,null);

            viewHolder.imgLaptop =(ImageView) convertView.findViewById(R.id.imageViewLaptop);
            viewHolder.txtTenLaptop =(TextView) convertView.findViewById(R.id.textViewTenLaptop);
            viewHolder.txtGiaLaptop =(TextView) convertView.findViewById(R.id.textViewGiaLaptop);
            viewHolder.txtMoTaLaptop =(TextView) convertView.findViewById(R.id.textViewMoTaLaptop);

            convertView.setTag(viewHolder);
        }else{
            viewHolder = (ViewHolder) convertView.getTag();
        }
        SanPham sanPham = (SanPham) getItem(position);

        viewHolder.txtTenLaptop.setText(sanPham.getTensanpham());
        DecimalFormat decimalFormat = new DecimalFormat("###,###,###");

        viewHolder.txtGiaLaptop.setText("Giá : "+decimalFormat.format(sanPham.getGiasanpham())+" VND");
        viewHolder.txtMoTaLaptop.setMaxLines(2);
        viewHolder.txtMoTaLaptop.setEllipsize(TextUtils.TruncateAt.END);
        viewHolder.txtMoTaLaptop.setText(sanPham.getMoTasanpham());
        Picasso.get().load(sanPham.getHinhAnhsanpham())
                .placeholder(R.drawable.noimage)
                .error(R.drawable.error)
                .into(viewHolder.imgLaptop);
        return convertView;
    }
}
