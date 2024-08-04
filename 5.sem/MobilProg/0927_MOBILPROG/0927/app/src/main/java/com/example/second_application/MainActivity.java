package com.example.second_application;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Intent intent = new Intent(this, MainActivity2.class);

        intent.putExtra("number", 42);

        //Uri data = Uri.parse("tel:12345");
        //Intent intent = new Intent(Intent.ACTION_DIAL, data);

        //Intent intent = new Intent(Intent.ACTION_VIEW, Uri.parse("https://uni-eszterhazy.hu"));

        startActivity(intent);
    }
}