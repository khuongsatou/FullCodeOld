package DAO;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Vector;

import BUS.Students;

public class conNetSQL {

	public conNetSQL() {
		;
	}

	public Connection getConnect() throws SQLException {
		Connection con = null;
		try {
			Class.forName("com.mysql.jdbc.Driver");
			/*
			 * String url = "jdbc:sqlserver://localhost:1433;databaseName=Web";
			 */
			con = DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/web", "root", "");
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}

		return con;
	}

	public ResultSet getResultSet(String tableName) throws SQLException {
		ResultSet rs = null;
		Statement stmt = new conNetSQL().getConnect().createStatement();
		String sql = "select * from " + tableName;
		rs = stmt.executeQuery(sql);
		return rs;
	}

	public void export(Vector<Vector<Object>> dataTable) {
		try {
			Connection con = new conNetSQL().getConnect();
			con.setAutoCommit(false);

			for (int i = 0; i < dataTable.size(); i++) {
				Vector<Object> row = dataTable.elementAt(i);
				String id = row.get(0).toString();
				String fn = row.get(1).toString();
				String ln = row.get(2).toString();
				String classid = row.get(3).toString();
				/*System.out.println("ID " + id + " First name " + fn + "Lat name " + ln + " Class ID " + classid);*/
				String sql = "Insert Into Students(id,fname,lname,classid)" + "values('N" + id + "',N'" + fn + "',N'"
						+ ln + "','N" + classid + "')";
				PreparedStatement pstmt = con.prepareStatement(sql);
				pstmt.executeUpdate();
			}
			con.setAutoCommit(true);
			con.commit();

		} catch (Exception e) {
			e.printStackTrace();
		}

	}

	public ArrayList<Students> getList() throws Exception {
		ArrayList<Students> list_students = new ArrayList<Students>();
		try {
			ResultSet rs = new conNetSQL().getResultSet("students");
			while (rs.next()) {
				String id = rs.getString("id");
				String fn = rs.getString("fname");
				String ln = rs.getString("lname");
				String classid = rs.getString("classid");
				list_students.add(new Students(id, fn, ln, classid));

			}

		} catch (SQLException e) {
			System.out.println("Connect is error");
		}
		return list_students;
	}

	public Vector<Vector<Object>> getList(String tables) {
		conNetSQL conDSN = null;
		Vector<Vector<Object>> tableRecored = new Vector<Vector<Object>>();
		try {
			conDSN = new conNetSQL();
			ResultSet rs = conDSN.getResultSet("students");
			while (rs.next()) {
				Vector<Object> rowrecord = new Vector<Object>();
				rowrecord.addElement(rs.getString("id"));
				rowrecord.addElement(rs.getString("fname"));
				rowrecord.addElement(rs.getString("lname"));
				rowrecord.addElement(rs.getString("classid"));
				tableRecored.addElement(rowrecord);
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
		return tableRecored;
	}

	public String[][] getListToArray(String tables) throws SQLException {
		conNetSQL conDSN = null;
		int column_count = new conNetSQL().getResultSet(tables).getMetaData().getColumnCount();
		String[][] data = new String[column_count][column_count];
		try {
			conDSN = new conNetSQL();
			ResultSet rs = conDSN.getResultSet("student");
			int row = 0;
			while (rs.next()) {
				String[] datarow = new String[column_count];
				for (int i = 0; i < column_count; i++) {
					rs.getString(i);
				}
				data[row] = datarow;
				row++;
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
		return data;
	}

	public Vector<String> getListNameField(String tables) {
		Vector<String> s = new Vector<String>();
		try {
			ResultSetMetaData rsmt = new conNetSQL().getResultSet(tables).getMetaData();
			int col_count = rsmt.getColumnCount();
			for (int i = 1; i <= col_count; i++) {
				s.add(rsmt.getColumnName(i));
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}

		return s;

	}

	public String[] getListFieldArray(String tables) throws SQLException {
		String[] s = null;
		try {
			ResultSetMetaData rsmt = new conNetSQL().getResultSet(tables).getMetaData();
			int col_count = rsmt.getColumnCount();
			s = new String[col_count];
			for (int i = 1; i < col_count; i++) {
				s[i] = rsmt.getColumnName(i);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}

		return s;

	}

}
