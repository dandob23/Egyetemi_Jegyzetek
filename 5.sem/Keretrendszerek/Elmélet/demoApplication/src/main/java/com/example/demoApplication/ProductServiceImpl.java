package com.example.demoApplication;

import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class ProductServiceImpl implements ProductService{

    static ArrayList<Product> productRepository =
            new ArrayList<>();
    static {
        productRepository.add(new Product(
                productRepository.size(),
                "Cola",
                "1.0"
        ));
        productRepository.add(new Product(
                productRepository.size(),
                "Sandwich",
                "3.0"
        ));
        productRepository.add(new Product(
                productRepository.size(),
                "Salad",
                "4.0"
        ));
    }


    @Override
    public void createProduct(Product product) {
        productRepository.add(product);
    }

    @Override
    public void deleteProduct(int id) {
        productRepository.remove(id);
    }

    @Override
    public void updateProduct(int id, Product newProduct) {
        productRepository.remove(id);
        newProduct.setId(id);
        productRepository.add(newProduct);
    }

    @Override
    public List<Product> listProducts() {
        return productRepository;
    }
}
