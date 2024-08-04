package com.example.bl7vqv;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.util.Log;

import java.io.BufferedReader;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;

public class BelsoTarhelyActivity extends AppCompatActivity {

    private static final String FILE_NAME = "belso_file.txt";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_belso_tarhely);

        String data = "Mintadarab belső tárhelyen.";

        //fájl írása
        try (FileOutputStream fileOutputStream = openFileOutput(FILE_NAME, Context.MODE_PRIVATE)){
            fileOutputStream.write(data.getBytes());
            Log.d("BelsoTarhelyActivity", "Fájl írása belső tárhelyre: " + FILE_NAME);
        } catch (IOException e){
            e.printStackTrace();
        }

        //fájl olvasása
        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(openFileInput(FILE_NAME)))){
            StringBuilder stringBuilder = new StringBuilder();
            String line;
            while((line = bufferedReader.readLine()) != null){
                stringBuilder.append(line).append('\n');
            }
            Log.d("BelsoTarhelyActivity", "Fájl tartalma belső tárhelyről: "+ stringBuilder.toString());
        } catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}