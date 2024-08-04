package com.example.demo;

import org.springframework.context.annotation.Scope;
import org.springframework.stereotype.Component;

import java.util.Calendar;

@Scope("prototype")
@Component
public class CurrentTime {

    String currentTime = Calendar.getInstance().getTime().toString();

    public String getCurrentTime() {
        return currentTime;
    }
}
