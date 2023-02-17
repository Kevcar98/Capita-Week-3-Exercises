using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Explorer
{
    class Rectangle
    {
        public double RArea(double x, double y)
        {
            double Area = x* y;
            return Area;
        }
        public double RPerimeter(double x, double y)
        {
            double Per = (2*x)+(2*y);
            return Per;
        }
    }
}
