using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Input rectangle width: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input rectangle height: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double area = x * y;

        double perimeter = 2 * x + 2 * y;

        Console.WriteLine("Area: {0}\nPerimeter: {1}", area, perimeter);
    }
}11