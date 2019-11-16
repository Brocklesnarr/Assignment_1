using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius: ");
            double rad =Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(rad);
            Console.WriteLine("\n");
            Console.WriteLine(circle.circleDetails());
            Console.ReadKey();
        }
    }
}
