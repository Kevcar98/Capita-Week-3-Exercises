using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test_Explorer
{
    [TestFixture]
    internal class TriangleTest
    {
        [Test]
        public void ATriangle()
        {
            Triangle tri = new Triangle();
            double x = 3;
            double y = 4;
            double z = 5;
            double ExpectedValue = 6;
            double actualValue = tri.ATriangle(x, y, z);
            Assert.AreEqual(ExpectedValue, actualValue);
        }
        [Test]
        public void PTriangle()
        {
            Triangle tri = new Triangle();
            double x = 3;
            double y = 4;
            double z = 5;
            double ExpectedValue = 12;
            double actualValue = tri.PTriangle(x, y, z);
            Assert.AreEqual(ExpectedValue, actualValue);
        }
    }
}
