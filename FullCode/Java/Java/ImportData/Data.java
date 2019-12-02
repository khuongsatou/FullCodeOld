package sinhvien.nguyenvankien;

import android.content.Context;

public class Data {
		
		DataManager DB;
		Context context;
		public Data(Context context){
			this.context = context;
			DB = new DataManager(context);
			DB.CreateDB();
		}
		public void create(){
			/*Câu 1*/
			DB.InsertQuestion("01", "Bạn đang trên đường từ trường về nhà thì bắt được một chiếc ví có khá nhiều tiền trong đó. Bạn sẽ làm gì?", "A");
			
			DB.InsertAnwser("A", "Đưa cho công an.", "01");
			DB.InsertAnwser("B", "Mang về nhà và hỏi ý kiến người thân.", "01");
			DB.InsertAnwser("C", "Lấy số tiền đó và bỏ chiếc ví lại.", "01");
			DB.InsertAnwser("D", "Không biết làm gì", "01");
			
			/*Câu 2*/
			DB.InsertQuestion("02", "Nhỏ bạn thân mới cắt tóc. Nhỏ nghĩ kiểu tóc đó rất đẹp, nhưng bạn nghĩ nhỏ trông như chú chó xù. Khi nhỏ hỏi bạn có thích kiểu tóc mới đó không, bạn sẽ trả lời ra sao?", "B");
			DB.InsertAnwser("A", "Bạn đẹp lắm!", "02");
			DB.InsertAnwser("B", "Đẹp đấy, và nó sẽ đẹp hơn khi tóc bạn dài hơn một chút.", "02");
			DB.InsertAnwser("C", "Thật sự là nó chẳng tôn vẻ đẹp của bạn lên đâu!", "02");
			DB.InsertAnwser("D", "Không biết trả lời sao", "02");
			
			/*Câu 3*/
			DB.InsertQuestion("03", "Bạn đang trên đường từ trường về nhà thì bắt được một chiếc ví có khá nhiều tiền trong đó. Bạn sẽ làm gì?", "C");
			DB.InsertAnwser("A", "Đưa cho công an.", "03");
			DB.InsertAnwser("B", "Mang về nhà và hỏi ý kiến người thân.", "03");
			DB.InsertAnwser("C", "Lấy số tiền đó và bỏ chiếc ví lại.", "03");
			DB.InsertAnwser("D", "Không biết làm gì", "03");
			
			/*Câu 4*/
			DB.InsertQuestion("04", "Bạn gặp em của bạn trai bạn tại một bữa tiệc. Cô ấy giễu cợt phong cách hôn ướt át của bạn trai bạn và sự thật là, anh ấy là một người có cách “âu yếm ướt át”. Bạn sẽ nói lại với cô ấy như thế nào?", "D");
			DB.InsertAnwser("A", "anh ấy là người hôn giỏi nhất mà mình từng gặp", "04");
			DB.InsertAnwser("B", "Sao cũng được, anh ấy đang định hôn mình đấy!", "04");
			DB.InsertAnwser("C", "anh ấy có nụ hôn rất ướt át sao?", "04");
			DB.InsertAnwser("D", "Không biết làm gì", "04");
			
		}
		public String gettingStart(){
			return DB.starting();
		}
		public String[] choice(String code){
			return DB.ShowAnwser(code);
		}
		public String Result(String code){
			return DB.checkAnwser(code);
		}
		public String QuestionWith(String code){
			return DB.ShowQuestion(code);
		}
		public int count(){
			return DB.countQuestion();
		}
}
