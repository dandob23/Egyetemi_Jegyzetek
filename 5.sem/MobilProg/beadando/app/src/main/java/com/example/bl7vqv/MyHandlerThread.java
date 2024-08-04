package com.example.bl7vqv;

import android.os.Handler;
import android.os.HandlerThread;

public class MyHandlerThread extends HandlerThread {
    private Handler handler;

    public MyHandlerThread(String name){
        super(name);
    }

    public void postTask(Runnable task){
        handler.post(task);
    }

    public void prepareHandler(){
        handler = new Handler(getLooper());
    }
}
