using FiguresLibrary.Library;
using NUnit.Framework;

namespace FiguresLibrary.Tests
{
    public class CircleTests
    {
        [Test]
        public void Circle_TestSquare_5()
        {
            //arrange
            double r = 5;
            var expected = 78.539816339744831;
            Figure circle = new Circle(r);

            //act
            var result = circle.GetSquare();

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
