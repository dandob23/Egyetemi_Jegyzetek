import org.example.Calculator;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class CalculatorTest {
    Calculator calculator = new Calculator();

    @Test
    void testAddition(){
        assertEquals(5, calculator.add(2,3), "2 + 3 should be 5");
        assertEquals(0, calculator.add(-1,1), "-1 + 1 should be 0");
    }

    @Test
    void testSubtraction(){
        assertEquals(1, calculator.subtract(3,2), "3 - 2 should be 1");
        assertEquals(-4, calculator.subtract(-2,2), "-2 - 2 should be -4");
    }

    @Test
    void testMultiplication(){
        assertEquals(6, calculator.multiply(2,3), "2 * 3 should be 6");
        assertEquals(0, calculator.multiply(0,5), "0 * 5 should be 0");
        assertEquals(-15, calculator.multiply(-3,5), "-3 * 5 should be -15");
    }

    @Test
    void testDivision(){
        assertEquals(2, calculator.divide(6,3), "6 / 3 should be 2");
        assertEquals(-3, calculator.divide(-9,3), "-9 / 3 should be -3");
    }

    @Test
    void testDivisionByZero(){
        Exception exception = assertThrows(IllegalArgumentException.class, () -> {
            calculator.divide(5,0);
        });
        assertEquals("Divider cannot be zero", exception.getMessage());
    }

}
