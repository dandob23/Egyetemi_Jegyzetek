package com.example.demo;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import java.util.Date;

@Configuration
public class BeanContainer {

    // A Bean neve a metódus neve lesz, ha
    // az @Bean-ben nem adunk más nevet neki.
    @Bean
    public Date dateBean(){
        return new Date();
    }
}
