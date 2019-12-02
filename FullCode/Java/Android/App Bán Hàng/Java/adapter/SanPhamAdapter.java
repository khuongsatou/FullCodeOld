package com.example.bestchikass3of2.adapter;

import android.content.Context;
import android.content.Intent;
import android.support.annotation.NonNull;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.bestchikass3of2.R;
import com.example.bestchikass3of2.activity.ChiTietSanPham;
import com.example.bestchikass3of2.model.SanPham;
import com.example.bestchikass3of2.until.CheckConnection;
import com.squareup.picasso.Picasso;

import java.text.DecimalFormat;
import java.util.ArrayList;

public class SanPhamAdapter extends RecyclerView.Adapter<SanPhamAdapter.ItemHolder> {
    Context context;
    ArrayList<SanPham> sanPhamArrayList;

    public SanPhamAdapter(Context context, ArrayList<SanPham> sanPhamArrayList) {
        this.context = context;
        this.sanPhamArrayList = sanPhamArrayList;
    }

    @NonNull
    @Override
    public ItemHolder onCreateViewHolder(@NonNull ViewGroup viewGroup, int i) {
        View v = LayoutInflater.from(viewGroup.getContext()).inflate(R.layout.dong_sanpham_moi_nhat,null);
        ItemHolder itemHolder = new ItemHolder(v);
        return itemHolder;

    }

    @Override
    public void onBindViewHolder(@NonNull ItemHolder itemHolder, int i) {
        SanPham sanPham = sanPhamArrayList.get(i);
        itemHolder.txtTenSanPham.setText(sanPham.getTensanpham());
        DecimalFormat decimalFormat = new DecimalFormat("###,###,###");
        itemHolder.txtGiaSanPham.setText("Giá : " + decimalFormat.format(sanPham.Giasanpham) + " VND");
        Picasso.get().load(sanPham.getHinhAnhsanpham())
                .placeholder(R.drawable.noimage)
                .error(R.drawable.error)
                .into(itemHolder.imgHinhSanPham);

    }

    @Override
    public int getItemCount() {
        return sanPhamArrayList.size();
    }

    public class ItemHolder extends  RecyclerView.ViewHolder{
        public ImageView imgHinhSanPham;
        public TextView txtTenSanPham,txtGiaSanPham;

        public ItemHolder(@NonNull View itemView) {
            super(itemView);
            imgHinhSanPham =(ImageView) itemView.findViewById(R.id.imageViewSanPham);
            txtTenSanPham =(TextView) itemView.findViewById(R.id.textViewTenSanPham);
            txtGiaSanPham=(TextView) itemView.findViewById(R.id.textViewGiaSanPham);

            itemView.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent intent = new Intent(context, ChiTietSanPham.class);
                    intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                    intent.putExtra("thongtinsanpham",sanPhamArrayList.get(getPosition()));
                    context.startActivity(intent);
                }
            });

        }
    }


}
