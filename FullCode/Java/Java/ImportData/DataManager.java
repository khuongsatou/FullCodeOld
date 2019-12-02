package sinhvien.nguyenvankien;


import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.util.Log;

public class DataManager {
	
	Context context;
	SQLiteDatabase DBManager;
	DBHelper db;
	
	
	public DataManager(Context context){
		this.context = context;
	}
	
	public void CreateDB(){
		db = new DBHelper(context);
	}
	
	public boolean InsertQuestion(String code, String content, String anwser){
		try{
			
			DBManager = db.getWritableDatabase();
			ContentValues values = new ContentValues();

		    values.put(DBHelper.CODE_COLUMS, code);
		    values.put(DBHelper.CONTENT_COLUMS, content);
		    values.put(DBHelper.ANWSER_COLUMS, anwser);

		    DBManager.insert(DBHelper.TABLE_NAME_1, null, values);
		    
		}catch(SQLException exp){
			Log.d("ERROR INSERT DATABASE ", exp.getMessage());
			return false;
		}
		return true;
	}
	
	
	public boolean InsertAnwser(String anwser, String content, String code){
		try{
			
			DBManager = db.getWritableDatabase();
			ContentValues values = new ContentValues();
			
		    values.put(DBHelper.ANWSER_COLUMS_, anwser);
		    values.put(DBHelper.CONTENT_COLUMS_, content);
		    values.put(DBHelper.CODE_COLUMS_, code);
		    
		    DBManager.insert(DBHelper.TABLE_NAME_2, null, values);
		    
		}catch(SQLException exp){
			Log.d("ERROR INSERT DATABASE ", exp.getMessage());
			return false;
		}
		return true;
	}
	
	public boolean deleteAll(){
		
		try{
			DBManager = db.getWritableDatabase();
			DBManager.delete(DBHelper.TABLE_NAME_1, null, null);
			DBManager.delete(DBHelper.TABLE_NAME_2, null, null);
			
		}catch(SQLException exp){
			Log.d("ERROR DELETE DATABASE ", exp.getMessage());
			return false;
		}
		return true;
	}
	
	
	
	public String starting(){
		DBManager = db.getReadableDatabase();
		Cursor c = DBManager.query(DBHelper.TABLE_NAME_1, 
								   new String[]{DBHelper.CONTENT_COLUMS},
								   null, null, null, null, null);
		c.moveToFirst();
		return c.getString(c.getColumnIndex("CONTENT"));
	}
	
	public String[] ShowAnwser(String code){
		String[] result = new String[4];
		
		DBManager = db.getReadableDatabase();
		Cursor c = DBManager.query(DBHelper.TABLE_NAME_2, 
								   new String[]{DBHelper.ANWSER_COLUMS_, DBHelper.CONTENT_COLUMS_, DBHelper.CODE_COLUMS_},
								   DBHelper.CODE_COLUMS_ + " = " + "'"+code+"'", null, null, null, null);
		int i = 0;
		while(c.moveToNext() && i<4){
			result[i] = c.getString(c.getColumnIndex("CONTENT"));
			i++;
		}
		return result;
	}
	
	public String checkAnwser(String code){
		
		DBManager = db.getReadableDatabase();
		Cursor c = DBManager.query(DBHelper.TABLE_NAME_1, 
								   new String[]{DBHelper.ANWSER_COLUMS},
								   DBHelper.CODE_COLUMS + " = " + "'"+code+"'", null, null, null, null);
		c.moveToFirst();
		return c.getString(c.getColumnIndex("ANWSER"));
	}
	public String ShowQuestion(String code){
		
		DBManager = db.getReadableDatabase();
		Cursor c = DBManager.query(DBHelper.TABLE_NAME_1, 
								   new String[]{DBHelper.CONTENT_COLUMS},
								   DBHelper.CODE_COLUMS + " = " + "'"+code+"'", null, null, null, null);
		c.moveToFirst();
		return c.getString(c.getColumnIndex("CONTENT"));
	}
	public int countQuestion(){
		DBManager = db.getReadableDatabase();
		Cursor c = DBManager.query(DBHelper.TABLE_NAME_1, 
								   new String[]{"ID"},
								   null, null, null, null, null);
		int i = 0;
		while(c.moveToNext()) ++i;
		return i;
	}
	
}