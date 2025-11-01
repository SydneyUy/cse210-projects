using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        int answer = -1;

        while (answer != randomNumber)
        {
            Console.Write("Guess the number: ");
            answer = int.Parse(Console.ReadLine());
            if (randomNumber > answer)
            {
                Console.WriteLine("higher");
            }
            else if (randomNumber < answer)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}