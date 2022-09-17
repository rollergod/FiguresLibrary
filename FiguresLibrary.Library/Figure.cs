using FiguresLibrary.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Library
{
    public abstract class Figure : ISquare
    {
        public abstract double GetSquare();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Площадь: {Math.Round(GetSquare(), 2)}");
        }
    }
}
