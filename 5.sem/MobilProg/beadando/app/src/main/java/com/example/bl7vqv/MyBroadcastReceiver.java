package com.example.bl7vqv;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.widget.Toast;

public class MyBroadcastReceiver extends BroadcastReceiver {
    @Override
    public void onReceive(Context context, Intent intent){
        String action = intent.getAction();

        if (action != null && action.equals("com.example.MY_ACTION")){
            String message = intent.getStringExtra("message");
            if (message != null){
                Toast.makeText(context, "Broadcast received: " + message, Toast.LENGTH_SHORT).show();
            }
        } else if (Intent.ACTION_BATTERY_LOW.equals(action)){
            Toast.makeText(context, "Low battery!", Toast.LENGTH_SHORT).show();
        }
    }
}
