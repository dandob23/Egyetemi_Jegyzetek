package org.example;

import com.google.gson.Gson;

public class Main {
    public static void main(String[] args) {

        String jsonString = "{\"products\":[" +
                "{\"quantity\":10,\"id\":\"00000001\",\"name\":\"Cola\",\"type\":\"Beverage\"}," +
                "{\"quantity\":4,\"id\":\"00000002\",\"name\":\"Tuna Sandwich\",\"type\":\"Food\"}, " +
                "{\"quantity\":0,\"id\":\"00000003\",\"name\":\"Salad\",\"type\":\"Fresh Food\"}]" +
                "}";

        Gson gson = new Gson();
        Products products = gson.fromJson(jsonString, Products.class);

        for(int i=0; i<products.products.size(); ++i){
            System.out.println(products.products.get(i).id);
            System.out.println(products.products.get(i).name);
            System.out.println(products.products.get(i).type);
            System.out.println(products.products.get(i).quantity);
        }
    }
}