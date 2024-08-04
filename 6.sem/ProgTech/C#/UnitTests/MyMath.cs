using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class MyMath
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Div(double divisor, double dividend)
        {
            if (dividend == 0)
            {
                throw new DivideByZeroException();
            }
            return divisor / dividend;
        }

        public const double PI= 3.1415;
        public const string sPI = "3.1415";
    }
}
