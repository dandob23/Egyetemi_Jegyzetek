package com.example.demo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class RestApi {

    @Autowired
    CurrentTime currentTime;

    @RequestMapping("/")
    public String hello(){
        return currentTime.getCurrentTime();
    }
}
