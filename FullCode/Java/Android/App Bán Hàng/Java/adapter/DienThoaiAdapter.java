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

import org.w3c.dom.Text;

import java.text.DecimalFormat;
import java.util.ArrayList;

public class DienThoaiAdapter extends BaseAdapter {
    Context context;
    ArrayList<SanPham> sanPhamArrayList;

    public DienThoaiAdapter(Context context, ArrayList<SanPham> sanPhamArrayList) {
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
        ImageView imgDienThoai;
        TextView txtTenDienThoai,txtGiaDienThoai,txtMoTaDienThoai;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        ViewHolder viewHolder;
        if (convertView == null){
            viewHolder = new ViewHolder();
            LayoutInflater layoutInflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            convertView = layoutInflater.inflate(R.layout.dong_dien_thoai,null);

            viewHolder.imgDienThoai =(ImageView) convertView.findViewById(R.id.imageViewDienThoai);
            viewHolder.txtTenDienThoai =(TextView) convertView.findViewById(R.id.textViewTenDienThoai);
            viewHolder.txtGiaDienThoai =(TextView) convertView.findViewById(R.id.textViewGiaDienThoai);
            viewHolder.txtMoTaDienThoai =(TextView) convertView.findViewById(R.id.textViewMoTaDienThoai);

            convertView.setTag(viewHolder);
        }else{
            viewHolder = (ViewHolder) convertView.getTag();
        }
        SanPham sanPham = (SanPham) getItem(position);

        viewHolder.txtTenDienThoai.setText(sanPham.getTensanpham());
        DecimalFormat decimalFormat = new DecimalFormat("###,###,###");

        viewHolder.txtGiaDienThoai.setText("Giá : "+decimalFormat.format(sanPham.getGiasanpham())+" VND");
        viewHolder.txtMoTaDienThoai.setMaxLines(2);
        viewHolder.txtMoTaDienThoai.setEllipsize(TextUtils.TruncateAt.END);
        viewHolder.txtMoTaDienThoai.setText(sanPham.getMoTasanpham());
        Picasso.get().load(sanPham.getHinhAnhsanpham())
                .placeholder(R.drawable.noimage)
                .error(R.drawable.error)
                .into(viewHolder.imgDienThoai);
        return convertView;
    }
}
