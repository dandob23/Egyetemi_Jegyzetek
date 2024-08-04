package org.example;

import java.io.*;
import java.util.HashMap;
import java.util.Map;

public class CacheManager {

    private Map<String, Integer> cache;

    public CacheManager(){
        cache = new HashMap<>();
    }

    public Integer getFromCache(String key) {
        return cache.get(key);
    }

    public void putInCache(String key, int value){
        cache.put(key,value);
    }
    public void loadCacheFromFile(String fileName){
        try {
            File file = new File(fileName);
            if (file.exists()){
                BufferedReader br = new BufferedReader(new FileReader(file));
                String line;
                while ((line = br.readLine()) != null){
                    String[] parts = line.split("-");
                    int n = Integer.parseInt(parts[0]);
                    int k = Integer.parseInt(parts[1]);
                    int result = Integer.parseInt(parts[2]);
                    cache.put(n + "-" + k, result);
                }
                br.close();
            }
        }catch (IOException e){
            e.printStackTrace();
        }
    }

    public void saveCacheToFile(String fileName){
        try{
            BufferedWriter bw = new BufferedWriter(new FileWriter(fileName));
            for (Map.Entry<String, Integer> entry : cache.entrySet()){
                bw.write(entry.getKey()+ "-" + entry.getValue());
                bw.newLine();
            }
            bw.close();
        }catch (IOException e){
            e.printStackTrace();
        }
    }
}
