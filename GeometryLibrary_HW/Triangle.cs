using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary_HW
{
    public class Triangle : IShape
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double CalculateArea()
        {
            double s = (_a + _b + _c) / 2;
            double area = Math.Sqrt(s* (s - _a) * (s - _b) * (s - _c));
            if (double.IsNaN(area) || double.IsInfinity(area)) throw new Exception("Неверные размеры треугольника");
            return area;
        }

        public bool IsRightTriangle()
        {
            return (Math.Pow(_a, 2) + Math.Pow(_b, 2) == Math.Pow(_c, 2) || 
                Math.Pow(_a, 2) + Math.Pow(_c, 2) == Math.Pow(_b, 2) ||
                Math.Pow(_b, 2) + Math.Pow(_c, 2) == Math.Pow(_a, 2));
        }
    }
}
