package com.example.second_application;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Toast;

public class MainActivity2 extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);

        Intent intent = getIntent();
        int data = intent.getIntExtra("number", -1);

        String convertedValue = String.valueOf(data);
        Toast.makeText(this, convertedValue, Toast.LENGTH_SHORT).show();
    }
}