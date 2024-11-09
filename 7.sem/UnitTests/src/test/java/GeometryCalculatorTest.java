import org.example.GeometryCalculator;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
public class GeometryCalculatorTest {
    GeometryCalculator geometryCalculator = new GeometryCalculator();

    @Test
    void testRectangleArea(){
        assertEquals(20, geometryCalculator.rectangleArea(4,5), "Area of a 4x5 rectangle should be 20");
        assertEquals(0, geometryCalculator.rectangleArea(0,5), "Area of a 0x5 rectangle should be 0");
        assertThrows(IllegalArgumentException.class, () -> geometryCalculator.rectangleArea(-4, 5), "Negative width should throw an exception");
        assertThrows(IllegalArgumentException.class, () -> geometryCalculator.rectangleArea(4, -5), "Negative width should throw an exception");
    }

    @Test
    void testRectanglePerimeter(){
        assertEquals(40, geometryCalculator.rectanglePerimeter(4,5), "Perimeter of a 4x5 rectangle should be 18");
        assertEquals(0, geometryCalculator.rectanglePerimeter(0,5), "Perimeter of a 0x5 rectangle should be 0");
        assertThrows(IllegalArgumentException.class, () -> geometryCalculator.rectanglePerimeter(-4, 5), "Negative width should throw an exception");
        assertThrows(IllegalArgumentException.class, () -> geometryCalculator.rectanglePerimeter(4, -5), "Negative width should throw an exception");
    }

    @Test
    void testCircleArea(){
        assertEquals(Math.PI * 9, geometryCalculator.circleArea(3),0.0001, "Area of a circle with radius 3 should be PI * 9");
        assertEquals(0, geometryCalculator.circleArea(0), "Area of a circle with radius 0 should be 0");
        assertThrows(IllegalArgumentException.class, () -> geometryCalculator.circleArea(-3), "Negative radius should throw an exception");
    }

    @Test
    void testCircleCircumference(){
        assertEquals(2 * Math.PI * 3, geometryCalculator.circleCircumference(3),0.0001, "Circumference of a circle with radius 3 should be 2 * PI * 3");
        assertEquals(0, geometryCalculator.circleCircumference(0), "Circumference of a circle with radius 0 should be 0");
        assertThrows(IllegalArgumentException.class, () -> geometryCalculator.circleCircumference(-3), "Negative radius should throw an exception");
    }
}
