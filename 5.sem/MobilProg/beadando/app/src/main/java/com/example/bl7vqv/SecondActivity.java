package com.example.bl7vqv;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.RecyclerView;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;

public class SecondActivity extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);

        TextView textView = findViewById(R.id.textView);

        Intent intent = getIntent();
        if (intent != null && intent.hasExtra("MESSAGE")){
            String message = intent.getStringExtra("MESSAGE");
            textView.setText(message);
        }

        //7.feladat

        Intent intent1 = getIntent();
        if (intent1!=null){
            int number1 = intent1.getIntExtra("NUMBER1",0);
            int number2 = intent1.getIntExtra("NUMBER2",0);

            int result = (number1 + number2)*2;

            Button sendResultButton = findViewById(R.id.sendResultButton);
            sendResultButton.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent resultIntent = new Intent();
                    resultIntent.putExtra("RESULT",result);
                    setResult(RESULT_OK, resultIntent);
                    finish();
                }
            });
        }

        //--------------//

        //10. feladat

        MyFragment fragment = MyFragment.newInstance("param1_value", "param2_value");

        getSupportFragmentManager().beginTransaction()
                .replace(R.id.fragment_container, fragment)
                .commit();

        //--------------//

        //16. feladat

        //assets
        try {
            String[] assetFiles = getAssets().list("");
            for (String fileName : assetFiles) {
                Log.d("Assets", "Fájl az Assets könyvtárban: " + fileName);
            }
        } catch (IOException e){
            e.printStackTrace();
        }

        //egy konkrét asset olvasása
        try (InputStream inputStream = getAssets().open("myFile.txt")){
            BufferedReader reader = new BufferedReader(new InputStreamReader(inputStream));
            StringBuilder stringBuilder = new StringBuilder();
            String line;
            while ((line = reader.readLine()) != null) {
                stringBuilder.append(line).append("\n");
            }
            String fileContents = stringBuilder.toString();
            Log.d("Assets", "Fájl tartalma az Assets könyvtárból: " + fileContents);
        }catch (IOException e){
            e.printStackTrace();
        }



        //raw
        try (InputStream inputStream = getResources().openRawResource(R.raw.my_raw_file)){
            BufferedReader reader = new BufferedReader(new InputStreamReader(inputStream));
            StringBuilder stringBuilder = new StringBuilder();
            String line;
            while ((line = reader.readLine()) != null) {
                stringBuilder.append(line).append("\n");
            }
            String fileContents = stringBuilder.toString();
            Log.d("RawResources", "Fájl tartalma a raw erőforrásból: " + fileContents);
        } catch (IOException e){
            e.printStackTrace();
        }

        //---------------//


    }
}
