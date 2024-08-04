package org.example;

public class BinomialCalculator {
    public static int calculate(int n, int k){
        if (k==0 || k==n){
            return 1;
        }
        return calculate(n-1, k-1) + calculate(n-1,k);
    }
}
