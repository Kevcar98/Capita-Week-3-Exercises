using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Explorer
{
    class Circle
    {
        public double Area(double Radius)
        {
            double CArea = Math.PI* Math.Pow(Radius,2);
            return CArea;
        }
        public double Perimeter(double Radius)
        {
            double CPerimeter = Math.PI*(Radius*2);
            return CPerimeter;
        }

    }
}
