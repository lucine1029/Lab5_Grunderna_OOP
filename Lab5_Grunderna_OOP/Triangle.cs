using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Grunderna_OOP
{
    internal class Triangle
    {
        public int BaseLenght { get; private set; }
        public int Height { get; private set; }
        public Triangle(int baseLenght, int height) 
        { 
            BaseLenght = baseLenght;
            Height = height;
        }
        public void GetArea() 
        { 
            double area = 0.5 * BaseLenght * Height;
            Console.WriteLine($"The triangle has baselenght {BaseLenght} cm and height {Height} cm, " +
                $"and it's area is {area} cm².");
        }
    }
}
