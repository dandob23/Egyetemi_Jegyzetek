package org.example;

public class Main {
    public static void main(String[] args)
    {
        CacheManager cacheManager = new CacheManager();
        cacheManager.loadCacheFromFile("binomial_cache.txt");

        ProxyBinomialCalculator proxyCalculator = new ProxyBinomialCalculator(cacheManager);


        int n = 100;
        int k = 5;
        int result = proxyCalculator.calculate(n, k);
        System.out.println("Binomiális együttható (" + n + "," + k + "): " + result);

        cacheManager.saveCacheToFile("binomial_cache.txt");
    }
}