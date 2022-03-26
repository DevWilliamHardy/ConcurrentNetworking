using System;

class Program
{
    public static void Main()
    {
        Random r = new Random();
        int number = r.Next(1, 100);
        int guess = 0;
        while(number != guess)
        {
            Console.WriteLine("Guess a number: ");
            guess = Convert.ToInt16(Console.ReadLine());
            if (guess > number)
            {
                Console.WriteLine("You guessed too high!");
            }
            else
            {
                Console.WriteLine("Your guess was too low!");
            }
        }
        Console.WriteLine("Congratulations you guessed the correct number!");
        


    }
}