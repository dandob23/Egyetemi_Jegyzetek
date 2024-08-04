package service;

import java.util.ArrayList;
import java.util.List;

public class ProductService {
    private static List<Product> products = new ArrayList<Product>();

    static {
        Product bread = new Product ("1", "kenyér", 1000);
        Product monitor = new Product ("2", "LG", 3000);

        products.add(bread);
        products.add(monitor);
    }

    public List<Product> returnProducts(){
        return products;
    }
}
