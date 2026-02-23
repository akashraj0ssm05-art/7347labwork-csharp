using System;

class Program
{
    static void Main()
    {
        double radius, area;

        Console.Write("Enter radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        area = Math.PI * radius * radius;

        Console.WriteLine("Area of the circle = " + area);
    }
}
