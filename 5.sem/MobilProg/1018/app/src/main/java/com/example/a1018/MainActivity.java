package com.example.a1018;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

public class MainActivity extends AppCompatActivity {

    String[] months = new String[]{"January", "February", "March", "January", "February", "March", "January", "February", "March", "January", "February", "March", "January", "February", "March", "January", "February", "March", "January", "February", "March"};


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ArrayAdapter<String> adapter= new ArrayAdapter<>
                (
                        MainActivity.this,
                        android.R.layout.simple_list_item_1,
                        months
                );


        ListView listView = findViewById(R.id.listView);

        listView.setAdapter(adapter);
    }
}


