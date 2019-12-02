package BUS;

public class Students {

	private String id = null;
	private String fristname = null;
	private String lastname = null;
	private String classid = null;

	public Students() {
		;
	}

	public Students(String id, String fn, String ln, String claasid) {
		this.id = id;
		this.fristname = fn;
		this.lastname = ln;
		this.classid = claasid;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getFristName() {
		return fristname;
	}

	public void setFristName(String fristname) {
		this.fristname = fristname;
	}

	public String getLastName() {
		return lastname;
	}

	public void setLastName(String lastname) {
		this.lastname = lastname;
	}

	public String getClassid() {
		return classid;
	}

	public void setClassid(String classid) {
		this.classid = classid;
	}

	public String toString() {
		return "Id " + this.id + "First name " + this.fristname
				+ "Last name " + this.lastname + "Id Class" + this.classid;
	}
}
