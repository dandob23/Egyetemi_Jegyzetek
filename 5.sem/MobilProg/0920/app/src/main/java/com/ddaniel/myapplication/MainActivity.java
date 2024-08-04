package com.ddaniel.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;

public class MainActivity extends AppCompatActivity {

    public static final String TAG= "MainActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //  GUI létrehozása
        setContentView(R.layout.activity_main);

        Log.d(TAG, "onCreate: MainActivity");
    }


    @Override
    protected void onStart() {
        super.onStart();
        Log.d(TAG, "OnStart");
    }

    @Override
    protected void onStop() {
        super.onStop();
        Log.d(TAG, "OnStop: MainActivity");

    }

    @Override
    protected void onPause() {
        super.onPause();
        Log.d(TAG, "OnPause: MainActivity");
    }

    @Override
    protected void onResume() {
        super.onResume();
        Log.d(TAG, "OnResume: MainActivity");
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        Log.d(TAG, "OnDestroy: MainActivity");
    }
}