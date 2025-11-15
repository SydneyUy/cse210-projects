using System;

class Program
{
    static void Main(string[] args)
    {
        //The program can end in one of two ways: Either the user types quit, or all of the words in the scripture have been hidden.

        // 1. Create reference and scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6); // Example for multiple verses
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        //2. Reapeating until all words are hidden
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // 3. Hide random words
            scripture.HideRandomWords(3); // Hide 3 words per round

            // 4. Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program will exit.");
                break;
            }
        }
    }
}