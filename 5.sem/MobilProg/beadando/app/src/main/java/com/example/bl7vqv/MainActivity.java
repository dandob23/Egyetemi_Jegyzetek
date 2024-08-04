package com.example.bl7vqv;

import android.Manifest;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import android.app.Activity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.pm.PackageManager;
import android.content.res.Configuration;
import android.net.Uri;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.SeekBar;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    private MyHandlerThread handlerThread;
    private TextView asyncTextView;
    Button counterButton;
    TextView counterTextView;
    int buttonClickCount=0;
    private SharedPreferences sharedPreferences;
    private static final int REQUEST_CODE = 1;
    private static final int CAMERA_PERMISSION_CODE = 100;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //2. feladat
        ImageView imageView = findViewById(R.id.imageView);
        SeekBar seekBar = findViewById(R.id.seekBar);
        seekBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener()
        {
            @Override
            public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {
                float imageWidth = imageView.getWidth();
                float maxProgress = seekBar.getMax();

                float translationX = (progress/maxProgress)*imageWidth;

                imageView.setTranslationX(translationX);
            }
            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {}
            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {}
        });
        //----------------//

        //4. feladat
        counterButton=findViewById(R.id.counterButton);
        counterTextView=findViewById(R.id.counterTextView);
        counterButton.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                buttonClickCount++;
                counterTextView.setText("Gomb lenyomva " + buttonClickCount + "x");
            }
        });
        //----------------//

        //5. feladat (nincs kész)
        Button explicitButton = findViewById(R.id.explicitButton);
        explicitButton.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                Intent explicitIntent = new Intent(MainActivity.this, SecondActivity.class);
                startActivity(explicitIntent);
            }
        });
        Button implicitButton = findViewById(R.id.implicitButton);
        implicitButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent implicitIntent = new Intent(Intent.ACTION_SEND);
                implicitIntent.setType("text/plain");
                implicitIntent.putExtra(Intent.EXTRA_TEXT, "Implicit inditás");
                startActivity(implicitIntent);
            }
        });
        //------------------//

        //6. feladat

        EditText editText = findViewById(R.id.editText);
        Button sendButton = findViewById(R.id.sendButton);

        sendButton.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                String message = editText.getText().toString();

                Intent intent = new Intent(MainActivity.this, SecondActivity.class);
                intent.putExtra("MESSAGE", message);
                startActivity(intent);
            }
        });

        //-----------------//

        //7. feladat

        Button calculateButton = findViewById(R.id.calculateButton);
        calculateButton.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                int number1=5;
                int number2=10;

                Intent intent = new Intent(MainActivity.this, SecondActivity.class);
                intent.putExtra("NUMBER1",number1);
                intent.putExtra("NUMBER2",number2);
                startActivityForResult(intent, REQUEST_CODE);
            }
        });

        //----------------//

        //8. feladat

        ListFragment listFragment = new ListFragment();
        DetailFragment detailFragment = new DetailFragment();

        getSupportFragmentManager().beginTransaction()
                .replace(R.id.listContainer, listFragment)
                .replace(R.id.detailContainer, detailFragment)
                .commit();

        //----------------//

        //14. feladat

        checkCameraPermission();

        //---------------//


        //17. feladat

        sharedPreferences = getSharedPreferences("MyPrefs", MODE_PRIVATE);

        //adatok tárolása
        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putString("name", "John Doe");
        editor.putInt("age", 30);
        editor.putBoolean("isStudent", true);

        editor.putString("name", "Some One");
        editor.putInt("age", 27);
        editor.putBoolean("isStudent", false);
        editor.apply();

        //adatok olvasása
        String name = sharedPreferences.getString("name", "Default Name");
        int age = sharedPreferences.getInt("age", 0);
        boolean isStudent = sharedPreferences.getBoolean("isStudent", false);

        //--------------//

        //20.feladat Async

        asyncTextView = findViewById(R.id.asyncTextView);

        MyAsyncTask myAsyncTask = new MyAsyncTask(asyncTextView);
        myAsyncTask.execute();

        //-------------//

        //21. feladat HandlerThread

        handlerThread = new MyHandlerThread("MyHandlerThread");
        handlerThread.start();
        handlerThread.prepareHandler();

        handlerThread.postTask(new Runnable() {
            @Override
            public void run() {
                Log.d("HandlerThread", "Példa üzenet a HandlerThread-ből");
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        Log.d("HandlerThread", "2. Példa üzenet a HandlerThread-ből");
                    }
                });
            }
        });

        //--------------//
    }

    @Override
    protected void onDestroy(){
        super.onDestroy();
        handlerThread.quit();
    }

    @Override //7.feladat része
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data){
        super.onActivityResult(requestCode,resultCode,data);
        if (requestCode == REQUEST_CODE && resultCode ==RESULT_OK && data != null){
            int result = data.getIntExtra("RESULT", 0);
        }
    }

    //@Override //9. feladat része
    public void callActivityMethod(){

    }

    //14. feladat
    private void checkCameraPermission(){
        if (ContextCompat.checkSelfPermission(this, Manifest.permission.CAMERA) != PackageManager.PERMISSION_GRANTED){
            ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.CAMERA}, CAMERA_PERMISSION_CODE);
        } else {

        }
    }
    public void onRequestPermissionResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults){
        if (requestCode == CAMERA_PERMISSION_CODE){
            if (grantResults.length > 0 && grantResults[0] == PackageManager.PERMISSION_GRANTED){
                //
            }else {
                Toast.makeText(this, "Kamera engedély szükséges!", Toast.LENGTH_SHORT).show();
            }
        }
    }
    //-----------------//



}