package com.example.a1011;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

class MainActivity extends AppCompatActivity
{
    TextView text;

    Button button;


    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        text = findViewById(R.id.textView);
        text.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                text.setText(" ");
            }
        });
        button = findViewById(R.id.Button);

        View.OnClickListener listener = new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                text.setText("Hello from Android");
            }
        };

        button.setOnClickListener(listener);
    }

    @Override
    public void onClick(View view){
        if (view.getId() == R.id.textView){
            text.setText(" ");
        }

    }
}