using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);


    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    { Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }  
    
    static int PromptUserNumber()
    {
     Console.Write("Favorite Number: ");
     int favNumber = int.Parse(Console.ReadLine());
     return favNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
        
        static void DisplayResult(string name, int square)
    {
        Console.Write($"{name}, the square of your number is {square}.");
    }
        
}