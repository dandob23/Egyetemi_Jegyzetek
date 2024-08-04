import org.junit.Assert;


public class MyMathTest {
    @org.junit.jupiter.api.Test
    void add(){
        MyMath myMath = new MyMath();
        double result = MyMath.Add(2,2);
        double expected = 4;
        Assert.assertEquals(expected,result,0.0001);
    }

    @org.junit.jupiter.api.Test
    void div(){
        MyMath myMath = new MyMath();
        Assert.assertThrows(ArithmeticException.class,
                () -> {
                    myMath.Div(5,0);
                });
    }
}
