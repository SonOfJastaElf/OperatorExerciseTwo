using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = CalculateArea(r);

            Console.WriteLine($"The area of a circle with radius {r} is {areaOfCircle}");
        }

    public static double CalculateArea(double radius) 
        {
            return Math.PI * (radius * radius);
        }
    }
}
