using FiguresLibrary.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Library
{
    public class Triangle : Figure, IPerimeter
    {
        public double A { get;private set; }
        public double B { get;private set; }
        public double C { get;private set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2);
        }

        public override double GetSquare()
        {
            var p = GetPerimeter();
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
        }

        public double GetPerimeter()
        {
            return (A + B + C) / 2;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Perimeter: {Math.Round(GetPerimeter(), 4)}");
            Console.WriteLine($"Является ли треугольник прямоугольным? - {IsRightTriangle()}");
        }
    }
}
