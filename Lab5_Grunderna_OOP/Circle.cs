using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Grunderna_OOP
{
    internal class Circle
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
        public double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }
        public double GetVolume() 
        { 
            return ((double) 4/3) * Math.Pow(Radius, 3) * Math.PI;
        
        }
    }
}
