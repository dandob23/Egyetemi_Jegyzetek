using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UnitTests;

namespace TestProject
{
    public class MyMathTester
    {
        private static double EPS = 0.0001;
        [Fact]
        public void MyMath_sPI_ReturnsString()
        {
            //string expected = "3.1415";
            //string result = MyMath.sPI;
            //Assert.Equal(expected, result);
            string result = MyMath.sPI;
            result.Should().NotContain(",");
            result.Should().StartWith("3");
            result.Should().Be("3.1415");
        }

        [Fact]
        public void MyMath_PI_ReturnsDouble()
        {
            double expected = 3.1415;
            double result = MyMath.PI;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MyMath_Add_TwoPointOnePlusThreePointTwoEqualsFivePointThree()
        {
            double a = 2.1;
            double b = 3.2;
            MyMath myMath = new MyMath();
            double result = myMath.Add(a, b);
            double expected = 5.3;
            Assert.Equal(expected, result, EPS);
        }

        [Theory]
        [InlineData(2.1, 3.2, 5.3)]
        [InlineData(21.1, 31.2, 52.3)]
        public void MyMath_Add_ReturnsDouble(double a, double b, double expected)
        {
            MyMath myMath = new MyMath();
            double result = myMath.Add(a, b);
            Assert.Equal(expected, result, EPS);
        }

        [Theory]
        [InlineData(5, 2, 2.5)]
        [InlineData(6.3, 2, 3.15)]
        public void MyMath_Div_ReturnsDouble(double divisor, double dividend, double expected)
        {
            MyMath myMath = new MyMath();
            double result = myMath.Div(divisor, dividend);
            result.Should().BeApproximately(expected, EPS);
        }

        [Theory]
        [InlineData(5, 0)]
        public void MyMath_Div_ThrowsDivideByZeroException(double divisor, double dividend)
        {
            MyMath myMath = new MyMath();
            myMath.Invoking(x => x.Div(divisor, dividend))
                .Should()
                .Throw<DivideByZeroException>();
        }
    }
}
