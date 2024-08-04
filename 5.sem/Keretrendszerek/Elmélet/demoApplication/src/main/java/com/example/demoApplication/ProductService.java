package com.example.demoApplication;

import java.util.List;

public interface ProductService {

    void createProduct(Product product);
    void deleteProduct(int id);
    void updateProduct(int id, Product newProduct);
    List<Product> listProducts();
}
