using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter score: ");
        string valueFromUser = Console.ReadLine();

        int UserScore = int.Parse(valueFromUser);

        if (UserScore >= 90)
        {
            Console.WriteLine("A");
        }
        else if (UserScore >= 80)
        {
            Console.WriteLine("B");
        }
        else if (UserScore >= 70)
        {
            Console.WriteLine("C");
        }
        else if (UserScore >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        if (UserScore == 70)
        {
            Console.Write("You passed!");
        }
        if (UserScore < 70)
        {
            Console.Write("Good luck next time!");
        }
    }
}