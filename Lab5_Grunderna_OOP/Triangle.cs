using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Grunderna_OOP
{
    internal class Triangle
    {
        public int BaseLenght { get; set; }
        public int Height { get; set; }
        public Triangle(int baseLenght, int height) 
        { 
            BaseLenght = baseLenght;
            Height = height;
        }
        public double GetArea() 
        { 
            return 0.5 * BaseLenght * Height;
        }
        


    }
}
