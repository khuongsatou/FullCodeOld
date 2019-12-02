package sinhvien.nguyenvankien;

import android.app.Activity;
import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Chronometer;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

public class Program extends Activity {
 
 RadioButton myOption1, myOption2, myOption3, myOption4;
 Button btnpre, btncenter, btnnext;
 Context context;
 TextView tv, tv1;
 String question;
 String anwser;
 String[] temp;
 private static int i = 1;
 String code = "0" + i;
 String NAME = "android";
 Chronometer mChronometer;
  /** Called when the activity is first created. */
  @Override
  public void onCreate(Bundle savedInstanceState) {
      super.onCreate(savedInstanceState);
      setContentView(R.layout.main);
      final Data data = new Data(Program.this);
      temp = new String[4];
      temp = data.choice(code);
     //String a = data.gettingStart();
      
      myOption1 = (RadioButton)findViewById(R.id.option1);
      myOption1.setText(temp[0]);
      
      myOption2 = (RadioButton)findViewById(R.id.option2);
      myOption2.setText(temp[1]);
      
      myOption3 = (RadioButton)findViewById(R.id.option3);
      myOption3.setText(temp[2]);
      
      myOption4 = (RadioButton)findViewById(R.id.option4);
      myOption4.setText(temp[3]);
      
      btnpre	= (Button)	this.findViewById(R.id.previous);
      btncenter	= (Button)	this.findViewById(R.id.center);
      btnnext	= (Button)	this.findViewById(R.id.next);
      
     
      tv = (TextView) this.findViewById(R.id.text);
      mChronometer = (Chronometer) this.findViewById(R.id.chronometer);
      mChronometer.setFormat("(%s)");
      mChronometer.start();
      tv.setText(data.gettingStart());
      
      myOption1.setOnClickListener(myOptionOnClickListener);
      myOption2.setOnClickListener(myOptionOnClickListener);
      myOption3.setOnClickListener(myOptionOnClickListener);
      myOption4.setOnClickListener(myOptionOnClickListener);
     
      btnpre.setOnClickListener(new View.OnClickListener() {
		@Override
		public void onClick(View arg0) {
 			if(i>2){
 			   Program.i--;
 			   code = "0" + i;
 			  tv.setText(data.QuestionWith(code));
 			  temp = data.choice(code);
 		      myOption1.setText(temp[0]);
 		      myOption2.setText(temp[1]);
 		      myOption3.setText(temp[2]);
 		      myOption4.setText(temp[3]);
 			}
 			else{
 				Toast.makeText(getApplicationContext(), "Trang Đầu", Toast.LENGTH_LONG).show();
 			}		
		}
	 });
      
      btncenter.setOnClickListener(new View.OnClickListener() {
  		@Override
  		public void onClick(View arg0) {
  			try{
	  			String result = data.Result(code);
	  			if(anwser.equals(result)){
	  				Toast.makeText(getApplicationContext(), "Ok", Toast.LENGTH_LONG).show();
	  			}
	  			else
	  				Toast.makeText(getApplicationContext(), "Bad", Toast.LENGTH_LONG).show();
  			}catch(Exception exp){
  				Toast.makeText(getApplicationContext(), "Bạn Chưa Chọn Đáp Án", Toast.LENGTH_LONG).show();
  			}
  		}
  	 });
      
      btnnext.setOnClickListener(new View.OnClickListener() {
  		@Override
  		public void onClick(View arg0) {
  			if(i<=3){
  			  Program.i++;
  	  		  code = "0" + i;
  			  tv.setText(data.QuestionWith(code));
  			  temp = data.choice(code);
  		      myOption1.setText(temp[0]);
  		      myOption2.setText(temp[1]);
  		      myOption3.setText(temp[2]);
  		      myOption4.setText(temp[3]);
  			}
  			else{
  				Toast.makeText(getApplicationContext(), "Trang Cuối", Toast.LENGTH_LONG).show();
  			}
  		     
  		}
  	 });
      
  }
  RadioButton.OnClickListener myOptionOnClickListener = new RadioButton.OnClickListener(){
	  	@Override
	  	public void onClick(View v) {
	  		
	  		if(myOption1.isChecked()){
	  			question = tv.getText().toString();
	  			anwser = "A";
	  		}	  			
	  		else if(myOption2.isChecked()) {
	  			question = tv.getText().toString();
	  			anwser = "B";
	  		}  			  		
	  		else if(myOption3.isChecked()){
	  			question = tv.getText().toString();
	  			anwser = "C";
	  		}	
	  	    else{
	  			question = tv.getText().toString();
	  			anwser = "D";
	  		} 
	  	}
   };
  
	@Override
	protected void onDestroy() {
		// TODO Auto-generated method stub
		super.onDestroy();
		mChronometer.stop();
	}
}