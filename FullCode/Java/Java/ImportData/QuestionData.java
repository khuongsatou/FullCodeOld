package sinhvien.nguyenvankien;

public class QuestionData {
		
		private String content;
		private String[] anwser;
		
		public QuestionData(){
			this.content = "";
			this.anwser = new String[4];
		}
		
		public void setContent(String content){
			this.content = content;
		}
		public String getContent(){
			return this.content;
		}
		
		public void setAnwser(String[] newanwser){
			this.anwser = newanwser;
		}
		public String[] getAnwser(){
			return this.anwser;
		}
}
