using System;
using System.Threading;

public class ThreadingStuff
{
    public static void Sort(int[] SortNumbers, int count)
    {
        int temp, smallest;
        
        for (int i = 0; i < SortNumbers.Length - 1; i++)
        {
            for(int j = i + 1; j < SortNumbers.Length; j++)
            {
                if(SortNumbers[i] > SortNumbers[j])
                {
                    temp = SortNumbers[i];
                    SortNumbers[i] = SortNumbers[j]; 
                    SortNumbers[j] = temp; 
                }
            }
        }

        
        Console.WriteLine("Sorted " + count);
    }

    public class SortArrays
    {
        static void Generate(int[] NewNumbers)
        {
            System.Random random = new System.Random();

            for (int i = 0; i < 10; i++)
                NewNumbers[i] = random.Next(50);

        }

        static void Toscreen(int[] NumsToPrint)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(NumsToPrint[i] + " ");

            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[] Numbers1 = new int[10];
            int[] Numbers2 = new int[10];
            int[] Numbers3 = new int[10];

            Generate(Numbers1);
            Generate(Numbers2);
            Generate(Numbers3);

            Console.WriteLine("Initial Lists Are: ");
            Console.WriteLine();

            Toscreen(Numbers1);
            Toscreen(Numbers2);
            Toscreen(Numbers3);

            Thread Thread1 = new Thread(new ThreadStart(() => ThreadingStuff.Sort(Numbers1, 1)));
            Thread Thread2 = new Thread(new ThreadStart(() => ThreadingStuff.Sort(Numbers2, 2)));
            Thread Thread3 = new Thread(new ThreadStart(() => ThreadingStuff.Sort(Numbers3, 3)));

            Thread1.Start();
            Thread2.Start();
            Thread3.Start();

            Thread1.Join();
            Thread2.Join();
            Thread3.Join();

            Console.WriteLine("Sorted Lists Are: ");
            Console.WriteLine();

            Toscreen(Numbers1);
            Toscreen(Numbers2);
            Toscreen(Numbers3);


        }
    }
}