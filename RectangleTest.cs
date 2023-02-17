using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test_Explorer
{
    [TestFixture]
    internal class RectangleTest
    {
        [Test]
        public void ATest()
        {
            Rectangle rect = new Rectangle();
            double x = 2;
            double y = 3;
            double ExpectedValue = 6;
            double actualValue = rect.RArea(x, y);
            Assert.AreEqual(ExpectedValue, actualValue);
        }
        [Test]
        public void PTest()
        {
            Rectangle rect = new Rectangle();
            double x = 2;
            double y = 3;
            double ExpectedValue = 10;
            double actualValue = rect.RPerimeter(x, y);
            Assert.AreEqual(ExpectedValue, actualValue);

        }
    }
}
