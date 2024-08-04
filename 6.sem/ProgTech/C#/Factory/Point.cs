using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Point
    {
        internal static class Factory
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
        private Point(double x, double y) { this.x = x; this.y = y; }

        public static Point CreateDescartesPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point CreatePolarPoint(double r, double alpha)
        {
            return new Point(r * Math.Cos(alpha), r * Math.Sin(alpha));
        }

        public double x { get; set; }
        public double y { get; set; }

        public override string ToString()
        {
            return $"Point [x='{x}';y='{y}']";
        }
    }
}
