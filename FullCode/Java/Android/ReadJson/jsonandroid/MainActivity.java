package ml.huytools.jsonandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import org.json.JSONException;

import java.io.IOException;

public class MainActivity extends AppCompatActivity {
   public static EditText outputText;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void runExample(View view){
        try {
            outputText=findViewById(R.id.outputText);
            Company company=ReadJSONExample.readCompanyJSONFile(this);
            outputText.setText(company.toString());

        } catch (JSONException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
