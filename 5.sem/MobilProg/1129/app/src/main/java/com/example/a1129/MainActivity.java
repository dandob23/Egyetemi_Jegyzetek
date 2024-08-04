package com.example.a1129;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.IntentFilter;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.util.Log;

public class MainActivity extends AppCompatActivity {

    MyReceiver myReceiver;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        SharedPreferences sharedPreferences = getSharedPreferences("data", MODE_PRIVATE);

        int value = sharedPreferences.getInt("key", -1);
        Log.d("MainActivity", String.valueOf(value));

        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putInt("key", 42);
        editor.commit();
        value = sharedPreferences.getInt("key", -1);
        Log.d("MainActivity", String.valueOf(value));

        myReceiver = new MyReceiver();
        IntentFilter intentFilter = new IntentFilter(Intent.ACTION_BATTERY_LOW);
        registerReceiver(myReceiver, intentFilter);


    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        unregisterReceiver(myReceiver);
    }
}