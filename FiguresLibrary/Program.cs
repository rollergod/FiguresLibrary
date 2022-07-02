using FiguresLibrary.Library;
using System;

namespace FiguresLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool Continue = true;
            do
            {
                Console.WriteLine("Какой объект создать?");
                Console.WriteLine("Круг - 1");
                Console.WriteLine("Треугольник - 2");
                var result = Console.ReadLine();

                switch (result)
                {
                    case "1":
                        Console.WriteLine("Введите радиус");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Figure circle = new Circle(radius);
                        Console.WriteLine($"Площадь круга - {circle.GetSquare()}");
                        
                        break;
                    case "2":
                        Console.WriteLine("Введите первую сторону");
                        double A = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите вторую сторону");
                        double B = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите третью сторону");
                        double C = Convert.ToDouble(Console.ReadLine());
                        Figure triangle = new Triangle(A, B, C);
                        triangle.DisplayInfo();
                        break;
                }
                Console.WriteLine("Создать еще объект? - Да/Нет");
                var test = Console.ReadLine();
                Continue = (test.ToLower() == "да") ? true : false;
            } while (Continue);

        }
    }
}
