using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Library
{
    public abstract class Figure
    {
        public abstract double GetSquare();
        //public abstract double GetPerimetr();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Площадь: {Math.Round(GetSquare(), 2)}");
            //Console.WriteLine($"Perimeter: {Math.Round(GetPerimetr(), 4)}");
        }
    }
}
