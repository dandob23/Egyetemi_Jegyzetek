package com.example.bl7vqv;

import android.os.AsyncTask;
import android.widget.TextView;

public class MyAsyncTask extends AsyncTask<Void, Void, String> {
    private TextView textView;

    public MyAsyncTask(TextView textView){
        this.textView = textView;
    }

    @Override
    protected String doInBackground(Void... voids){
        return "Eredmény a háttérfeldolgozásból";
    }

    @Override
    protected void onPostExecute(String result){
        textView.setText(result);
    }
}
