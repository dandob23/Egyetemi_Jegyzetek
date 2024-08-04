public class Main {
    public static void main(String[] args) {
        //System.out.println("Hello world!");
        boolean bo = true; // logikai  típus
        char c1 = 'a'; // karakter típus
        byte b1 = 127; // 8 bites egész típus
        short s  = 1024;// 16 bites egész
        int ii = 5000; // 32 bites egész
        long l = 1000000; // 64 bites egész
        float f = 123.123f; // 32 bites lebegopontos tipus
        double d = 5.0; // 64 bites lebegopontos

        int[] x = new int[5];
        int[][] y = new int[10][9];
        for (int i = 0; i < y.length; i++){
            for (int j = 0; j < y[i].length; j ++)
            {
                y[i][j] = (i+1)*(j+1)*3;
            }
        }
        final int tomeg = 10;
        //tomeg = 20;
    }
}