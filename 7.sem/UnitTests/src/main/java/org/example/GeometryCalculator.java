package org.example;

public class GeometryCalculator {
    public int rectangleArea(int width, int height){
        if(width < 0 || height < 0){
            throw new IllegalArgumentException("Width and height must be non-negative");
        }
        return width * height;
    }

    public int rectanglePerimeter(int width, int height){
        if(width < 0 || height < 0){
            throw new IllegalArgumentException("Width and height must be non-negative");
        }
        return 2 * (width * height);
    }

    public double circleArea(double radius){
        if(radius < 0){
            throw new IllegalArgumentException("Radius must be non-negative");
        }
        return Math.PI * radius * radius;
    }

    public double circleCircumference(double radius){
        if(radius < 0){
            throw new IllegalArgumentException("Radius must be non-negative");
        }
        return 2 * Math.PI * radius;
    }
}
