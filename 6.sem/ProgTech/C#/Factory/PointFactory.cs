using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class PointFactory
    {
        public static Point CreateDescartesPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point CreatePolarPoint(double r, double alpha)
        {
            return new Point(r * Math.Cos(alpha), r * Math.Sin(alpha));
        }
    }
}
