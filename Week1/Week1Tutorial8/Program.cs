using System;

class Program
{
    public static void Main()
    {
        var animals = new List<Animial>
        {
            new Cow(),
            new Sheep(),
            new Horse(),
            new Dolphin()
        };

        Console.WriteLine("[1] Cow\n[2] Sheep\n[3] Horse\n[4] Dolphin");
        animals[Convert.ToInt32(Console.ReadLine()) - 1].Speak();
    }
}

public class Animial
{
    public virtual void Speak()
    {
        Console.WriteLine("Base Class");
    }
}

public class Cow : Animial
{
    public override void Speak()
    {
        Console.WriteLine("Moooooooo");
    }
}

public class Sheep : Animial
{
    public override void Speak()
    {
        Console.WriteLine("Brrrrrrr");
    }
}

public class Horse : Animial
{
    public override void Speak()
    {
        Console.WriteLine("Nayyyyy");
    }
}

public class Dolphin : Animial
{
    public override void Speak()
    {
        Console.WriteLine("EEEEEEEK");
    }
}