package org.example;

import org.json.JSONArray;
import org.json.JSONObject;

public class Main {
    public static void main(String[] args) {

        String jsonString = "{\"products\":[{\"quantity\":10,\"id\":\"00000001\",\"name\":\"Cola\",\"type\":\"Beverage\"},{\"quantity\":4,\"id\":\"00000002\",\"name\":\"Tuna Sandwich\",\"type\":\"Food\"},{\"quantity\":0,\"id\":\"00000003\",\"name\":\"Salad\",\"type\":\"Fresh Food\"}]}";

        JSONObject object = new JSONObject(jsonString);
        JSONArray array = object.getJSONArray("products");

        for (int i = 0; i < array.length(); i++)
        {
            String id = array.getJSONObject(i).getString("id");
            System.out.println(id);

            String name = array.getJSONObject(i).getString("name");
            System.out.println(name);

            String type = array.getJSONObject(i).getString("type");
            System.out.println(type);

            int quantity = array.getJSONObject(i).getInt("quantity");
            System.out.println(String.valueOf( quantity ));
        }
    }
}