package org.example;

public class ProxyBinomialCalculator {
    private CacheManager cacheManager;

    public ProxyBinomialCalculator(CacheManager cacheManager){
        this.cacheManager = cacheManager;
    }

    public int calculate(int n, int k){
        String key = n + "-" + k;
        Integer cachedResult = cacheManager.getFromCache(key);
        if (cachedResult != null){
            return cachedResult;
        } else {
            int result = BinomialCalculator.calculate(n, k);
            cacheManager.putInCache(key, result);
            return result;
        }
    }
}
