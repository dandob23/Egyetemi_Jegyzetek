public class MyMath {
    public static double Add(double a, double b) {return a+b;}
    public double Div (double a, double b){
        if(b == 0) throw new ArithmeticException();
        return a/b;
    }
}
