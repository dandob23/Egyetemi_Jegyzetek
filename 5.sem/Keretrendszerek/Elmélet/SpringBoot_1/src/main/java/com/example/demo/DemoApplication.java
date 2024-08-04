package com.example.demo;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;

import java.util.Arrays;
import java.util.Date;

@SpringBootApplication
public class DemoApplication {

	public static void main(String[] args) {

		ApplicationContext context = SpringApplication.run(
				DemoApplication.class, args);

		// Az ApplicationContext segítségével érhetjük el az
		// futó alkalmazásunk környezetét. ...
		String[] beans = context.getBeanDefinitionNames();
		// Sorbarendezzük a jáva babokat
		Arrays.sort( beans );
		for(String name : beans){
			System.out.println( name );
		}

		Date date = context.getBean("dateBean", Date.class);
		System.out.println( date.getTime() );

	}

}
