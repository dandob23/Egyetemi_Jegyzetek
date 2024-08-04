package com.example.bl7vqv;

import androidx.annotation.WorkerThread;

import java.util.concurrent.Executor;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class MyThreadPool {
    public static void main(String[] args){
        ExecutorService executor = Executors.newFixedThreadPool(5);

        for (int i = 0; i<10;i++){
            Runnable worker = new MyWorkerThread("" +i);
            executor.execute(worker);
        }

        executor.shutdown();
        while (!executor.isTerminated()){

        }
        System.out.println("Minden szál befejeződött");
    }
}
class MyWorkerThread implements Runnable{
    private final String message;

    MyWorkerThread(String s){
        this.message = s;
    }

    public void run(){
        System.out.println(Thread.currentThread().getName() + " (Start) message = " + message);
        processMessage();
        System.out.println(Thread.currentThread().getName() + " (End)");
    }

    private void processMessage(){
        try {
            Thread.sleep(2000);
        } catch (InterruptedException e){
            e.printStackTrace();
        }
    }
}