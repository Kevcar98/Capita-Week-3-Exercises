using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test_Explorer
{
    [TestFixture]
    internal class CircleTest
    {
        [Test]
        public void AreaTest()
        {
            Circle CA= new Circle();
            double r = 4;
            double ExpectedValue = 50.26548245743669;
            double ActualValue = CA.Area(r);
            Assert.AreEqual(ExpectedValue, ActualValue);

        }
        [Test]
        public void PerimeterTest()
        {
            Circle CP= new Circle();
            double r = 4;
            double ExpectedValue = 25.132741228718345;
            double ActualValue = CP.Perimeter(r);
            Assert.AreEqual(ExpectedValue, ActualValue);

        }
    }
}
