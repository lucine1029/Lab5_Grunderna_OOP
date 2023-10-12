using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace Lab5_Grunderna_OOP
{
    internal class Circle
    {
        public int Radius { get; private set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public void GetArea()
        {
            double area = Math.Pow(Radius, 2) * Math.PI;
            Console.WriteLine($"The circle has radius of {Radius} cm, the area is {area:0.00} cm²");
        }
        public void GetCircumference()
        {
            double circuference = 2 * Radius * Math.PI;
            Console.WriteLine($"The circumference is {circuference:0.00} cm");
        }
        public void GetVolume() 
        { 
            double volume = ((double)4 / 3) * Math.Pow(Radius, 3) * Math.PI;
            Console.WriteLine($"The volume is {volume:0.00} cm³");
        }
    }
}
