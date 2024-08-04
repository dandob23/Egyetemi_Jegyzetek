package com.example.demo;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import java.sql.Array;
import java.util.ArrayList;
import java.util.List;

@RestController
public class ProductsController {

    @GetMapping(value = "/product")
    //@RequestMapping(value = "/product", method = RequestMethod.GET)
    public ResponseEntity<List<Product>> getProducts(){
        List<Product> products = new ArrayList<Product>();
        // Ezt majd pl adatbázisból kellene kinyerni.
        Product product = new Product("Cola", "2 EUR");
        products.add( product );
        products.add( new Product("Salad", "5 EUR") );
        return new ResponseEntity<>(products, HttpStatus.OK);
    }

}
