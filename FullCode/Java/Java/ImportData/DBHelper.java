package sinhvien.nguyenvankien;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

public class DBHelper extends SQLiteOpenHelper {

	/* public DBHelper(Context context, String name, CursorFactory factory,
			int version) {
		super(context, name, factory, version);
		// TODO Auto-generated constructor stub
	}*/

		/*public DBHelper(Context context, String name, CursorFactory factory,
			int version) {
		super(context, name, factory, version);
		// TODO Auto-generated constructor stub
	}*/

	 static final String DATABASE_NAME = "TRACNGHIEM.db";
	 static  int DATABASE_VERSION = 1;
	 
	 static final String TABLE_NAME_1    = "CAUHOI";
	 static final String TABLE_NAME_2    = "NGAUNHIEN";
	
	 /*Truong cho bang CAUHOI*/
	 static final String CODE_COLUMS = "CODE";
	 static final String CONTENT_COLUMS  = "CONTENT";
	 static final String ANWSER_COLUMS  = "ANWSER";
	
	 /*Truong cho bang NGAUNHIEN*/
	 static final String CODE_COLUMS_ = "CODE";
	 static final String CONTENT_COLUMS_  = "CONTENT";
	 static final String ANWSER_COLUMS_  = "ANWSER";
	 
	public DBHelper(Context context) {
		super(context, DATABASE_NAME, null, DATABASE_VERSION);
		
	}

	@SuppressWarnings("static-access")
	
	@Override
	public void onCreate(SQLiteDatabase db) {
		
		String query1 = "CREATE TABLE " + this.TABLE_NAME_1 + "(" + 
						"ID INTEGER PRIMARY KEY AUTOINCREMENT, " + 
						this.CODE_COLUMS + " TEXT," + 
						this.CONTENT_COLUMS + " TEXT," + 
						this.ANWSER_COLUMS + " TEXT" + ");";
		
		String query2 = "CREATE TABLE " + this.TABLE_NAME_2 + "(" + 
						"ID INTEGER PRIMARY KEY AUTOINCREMENT, " + 
						this.CODE_COLUMS_ + " TEXT," + 
						this.CONTENT_COLUMS_ + " TEXT," + 
						this.ANWSER_COLUMS_ + " TEXT" + ");";
		
		db.execSQL(query1);
		db.execSQL(query2);
		Log.d("SUCESS", "DATABASE CREATED");
	}

	@SuppressWarnings("static-access")
	
	@Override
	public void onUpgrade(SQLiteDatabase db, int arg1, int arg2) {
		// TODO Auto-generated method stub
		String queryupdate1 = "DROP TABLE IF EXISTS "+ this.TABLE_NAME_1;
		String queryupdate2 = "DROP TABLE IF EXISTS "+ this.TABLE_NAME_2;
		db.execSQL(queryupdate1);
		db.execSQL(queryupdate2);
		onCreate(db);
		++this.DATABASE_VERSION;
		Log.v("CONFIG :", "onUpgrade Method");
	}
	
}
