namespace Lab5_Grunderna_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Console.Write($"The circle has radius of {c1.Radius} and ");
            Console.WriteLine("the circle's area is {0:0.##}", c1.GetArea());
            Console.WriteLine("The circumference is {0:0.##}", c1.GetCircumference());
            Console.WriteLine("The volumn is {0:0.##}", c1.GetVolume());
            
            Console.WriteLine();
            Circle c2 = new Circle(6);
            Console.Write("The circle has radius of {c2.Radius} and ");
            Console.WriteLine("the circle's area is {0:0.##}", c2.GetArea());
            Console.WriteLine("The circumference is {0:0.##}", c2.GetCircumference());
            Console.WriteLine("The volumn is {0:0.##}", c2.GetVolume());

            Console.WriteLine();
            Triangle t = new Triangle(5, 10);
            Console.Write($"The triangle has baselenght {t.BaseLenght} and height {t.Height} and ");
            Console.WriteLine("the triangle's area is {0:0.##}", t.GetArea());
            Console.WriteLine();
        }
    }
}