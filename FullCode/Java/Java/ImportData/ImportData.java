package sinhvien.nguyenvankien;

import android.app.Activity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class ImportData extends Activity {
	
	String NAME = "android";
	Button btn1, btn2;
	final Data data = new Data(ImportData.this);
	@Override
	  public void onCreate(Bundle savedInstanceState) {
	      super.onCreate(savedInstanceState);
	      setContentView(R.layout.importdata);
	      btn1 = (Button) this.findViewById(R.id.importdata);
	      btn2 = (Button) this.findViewById(R.id.start);
	      
	      //import
	      btn1.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				SharedPreferences editPreference = ImportData.this.getSharedPreferences(NAME, Activity.MODE_PRIVATE);
		      	String check = editPreference.getString("HAVEDB", "No");
				if(check.equals("No")){
					SharedPreferences editor = ImportData.this.getSharedPreferences(NAME, Activity.MODE_APPEND);
					SharedPreferences.Editor update = editor.edit();
			      	update.putString("HAVEDB", "Yes");
			        update.commit();  
			        data.create();
	    			Toast.makeText(getApplicationContext(), "Database đã được tạo", Toast.LENGTH_LONG).show();
				}
			}
		  });
	      
	      btn2.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View v) {
					// TODO Auto-generated method stub
					SharedPreferences editPreference = ImportData.this.getSharedPreferences(NAME, Activity.MODE_PRIVATE);
			      	String check = editPreference.getString("HAVEDB", "No");
			      	if(check.equals("Yes")){
			      		Intent intent = new Intent(ImportData.this, Program.class);
			      		startActivity(intent);
			      	}
			      	else{
			      		Toast.makeText(getApplicationContext(), "Bạn Chưa Import Data", Toast.LENGTH_LONG).show();
			      	}
				}
			  });
	}
}
