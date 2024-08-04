package com.example.bl7vqv;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.os.Environment;
import android.util.Log;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;

public class KulsoTarhelyActivity extends AppCompatActivity {

    private static final String FILE_NAME = "kulso_file.txt";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_kulso_tarhely);

        String data = "Mintadarab külső tárhelyen. ";

        //van -e külső elérhető tárhely
        String state = Environment.getExternalStorageState();
        if (Environment.MEDIA_MOUNTED.equals(state)){
            File root = Environment.getExternalStorageDirectory();
            File file = new File(root, FILE_NAME);

            //fájl írása
            try (FileOutputStream fileOutputStream = new FileOutputStream(file)){
                fileOutputStream.write(data.getBytes());
                Log.d("KulsoTarhelyActivity", "Fájl írása külső tárhelyre: " + file.getAbsolutePath());
            }catch (IOException e){
                e.printStackTrace();
            }

            //fájl olvasása
            try (BufferedReader bufferedReader = new BufferedReader(new FileReader(file))){
                StringBuilder stringBuilder = new StringBuilder();
                String line;
                while((line = bufferedReader.readLine()) != null){
                    stringBuilder.append(line).append('\n');
                }
                Log.d("KulsoTarhelyActivity", "Fájl olvasása külső tárhelyről: " + stringBuilder.toString());
            } catch (IOException e){
                e.printStackTrace();
            }
        } else {
            Log.e("KulsoTarhelyActivity", "Nincs elérhető külső tárhely!");
        }
    }
}