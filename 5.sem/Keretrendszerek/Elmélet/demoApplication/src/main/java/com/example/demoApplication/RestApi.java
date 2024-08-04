package com.example.demoApplication;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
public class RestApi {

    @Autowired
    ProductService productService;

    @GetMapping(value = "/products")
    List<Product> listProducts(){
        return productService.listProducts();
    }

    @DeleteMapping(value = "/products/{id}")
    public ResponseEntity<String> deleteProduct(@PathVariable("id") int id){
        productService.deleteProduct( id );
        return new ResponseEntity<>("Product deleted", HttpStatus.OK);
    }

    @RequestMapping(value = "/products/{id}", method = RequestMethod.PUT)
    public ResponseEntity<String>
    updateProduct(@PathVariable("id") int id, @RequestBody Product newProduct) {
        productService.updateProduct(id, newProduct);
        return new ResponseEntity<>("Product is updated", HttpStatus.OK);
    }

    @RequestMapping(value = "/products2/{id}", method = RequestMethod.PUT)
    public String
    updateProductStringResponse(@PathVariable("id") int id, @RequestBody Product newProduct) {
        productService.updateProduct(id, newProduct);
        return "Product is updated";
    }

}
