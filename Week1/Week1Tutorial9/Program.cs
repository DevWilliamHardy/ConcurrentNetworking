class Program
{
    static void Main(string[] args)
    {
        Hangman hangman = new Hangman();
        hangman.Update();
    }
}

class Hangman
{
    //Member Variables
    int counter = -1;
    int m_Lives = 6;
    char[] m_IncorrectLetters = new char[26];
    char[] m_CorrectLetters = default!;
    string[] m_Words = {"boat", "gate", "toaster", "melon", "blender"};
    string m_Word;
    bool m_Won = false;
    char m_PlayAgain = 'n';

    Random r = new Random();

    public Hangman()
    {
        m_Word = m_Words[r.Next(0, m_Words.Length)];
        m_Word = m_Word.ToUpper();
        m_CorrectLetters = m_Word.ToCharArray();
        char[] m_displayWord = new char[m_Word.Length];

        foreach (char letter in m_displayWord)
        {
            counter++;
            m_displayWord[counter] = '-';
        }

        Console.WriteLine(m_Word);
        Console.WriteLine(m_IncorrectLetters);
        ShowHangman();
    }

    public void Update()
    {
        if (m_Lives > 0)
        {
            counter = -1;
            string displayProgress = String.Concat(m_displayWord);
            if (displayProgress == m_Word)
            {
                m_Won = true;
                break;
            }
            Console.WriteLine("You have {0} lives remaining.", m_Lives);

            Console.WriteLine(displayProgress);
            Console.WriteLine("\n");
            ShowHangman();
            Console.Clear();
        }
        Console.WriteLine("Guess a letter: ");
        char userInput;
        while (m_CorrectLetters.Contains((userInput = Char.ToLower(Console.ReadKey().KeyChar))))
        {
            Console.WriteLine(": You guessed the correct letter!");
            break;
        }
        //Check to see if the user has used a value 
        while (m_IncorrectLetters.Contains((userInput = Char.ToLower(Console.ReadKey().KeyChar))))
        {
            Console.WriteLine(": has already been guessed");
            break;
        }


        //Clear the screen
        Console.Clear();
        Update();
    }

    //Draw Hangman
    public void ShowHangman()
    {
        Console.WriteLine("     |------+  ");
        Console.WriteLine("     |      |  ");
        Console.WriteLine("     |      " + (m_Lives < 6 ? "O" : ""));
        Console.WriteLine("     |     " + (m_Lives < 4 ? "/" : "") + (m_Lives < 5 ? "|" : "") + (m_Lives < 3 ? @"\" : ""));
        Console.WriteLine("     |     " + (m_Lives < 2 ? "/" : "") + " " + (m_Lives < 1 ? @"\" : ""));
        Console.WriteLine("     |         ");
        Console.WriteLine("===============");
    }
}