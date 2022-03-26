using System;

class Program
{
    public static void Main()
    {
        int[] numbers = new int[10];
        int maximum;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Input Number: ");
            numbers[i] = Convert.ToInt16(Console.ReadLine());   
        }
        maximum = numbers.Max();
        Console.WriteLine(maximum);

    }
}