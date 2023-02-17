using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Explorer
{
    class Triangle
    {
        public double ATriangle(double x, double y, double z)
        {
            double SP=(x+y+z)/2;
            double Area = Math.Sqrt(SP*(SP-x)*(SP-y)*(SP-z));
            return Area;
        }
        public double PTriangle(double x, double y, double z)
        {
            return x + y + z;
        }
    }
}
