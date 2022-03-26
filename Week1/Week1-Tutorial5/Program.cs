using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Input number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input number: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Add(x, y));  
    }

    private static int Add(int x, int y)
        { return x + y; }

}