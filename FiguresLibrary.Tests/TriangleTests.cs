using FiguresLibrary.Library;
using NUnit.Framework;

namespace FiguresLibrary.Tests
{
    public class TriangleTests
    {
        
        [Test]
        public void Triangle_TestSquare_3_4_5()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            Triangle triangle = new Triangle(a, b, c);

            //act
            var result = triangle.GetSquare();

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Triangle_IsRightTriangle_3_4_5()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;
            Triangle triangle = new Triangle(a, b, c);

            //act
            var result = triangle.IsRightTriangle();

            //assert
            Assert.AreEqual(expected, result);
        }

        
    }
}