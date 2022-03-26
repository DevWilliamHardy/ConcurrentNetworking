using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Input number: ");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Input number: ");
        float y = float.Parse(Console.ReadLine());
        Console.WriteLine(Add(x, y));
    }

    private static int Add(int x, int y)
    { return x + y; }
    private static float Add(float x, float y)
    { return x + y; }

}