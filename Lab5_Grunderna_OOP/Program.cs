namespace Lab5_Grunderna_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            c1.GetArea();
            c1.GetCircumference();
            c1.GetVolume();
            Console.WriteLine();

            Circle c2 = new Circle(6);
            c2.GetArea();
            c2.GetCircumference();
            c2.GetVolume();
            Console.WriteLine();

            Triangle t = new Triangle(5, 10);
            t.GetArea();
            Console.WriteLine();
        }
    }
}