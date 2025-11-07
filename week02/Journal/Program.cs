using System;

class Program
{
    static void Main(string[] args)
    {
        //1 WRITE: needs a random prmpt and the user will answer. Maybe add all unsaved answers to a list? 
        //2 DISPLAY: you need a list. displays date, prompt and answer.
        //3 LOAD: load a journal. need use input on what is the filename
        //4 SAVE: Save everyting found on the list. ask user for the filename.

        Console.Write("JOURNAL WRITTING\n");

        int Userinput = -1;
        Journal journal = new Journal();
        Entry entry = new Entry();
        PromptGenerator generator = new PromptGenerator();

        while (Userinput != 5)
        {   
            Console.Write("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit\n");
            Console.Write("Select one of the corresponding numbers:\n");
            Userinput = int.Parse(Console.ReadLine());

            if (Userinput == 1)
            {
                Console.Write("What is the date today? ");
                string date = Console.ReadLine();

                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("");
                string response = Console.ReadLine();

                entry._date = date;
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);

            }
            else if (Userinput == 2)
            {
                journal.DisplayAll();
            }
            else if (Userinput == 3)
            {
                Console.Write("Enter filename to load: ");
                string loadfile = Console.ReadLine();
                journal.LoadFromFile(loadfile);
            }
            else if (Userinput == 4)
            {
                Console.Write("Enter filename to save: ");
                string savefile = Console.ReadLine();
                journal.SavetoFile(savefile);
            }
            else if (Userinput == 5)
            {
                Console.WriteLine("Closing program.");
            }
            else
            {
                Console.WriteLine("Enter a vaild number.");
            }
        }
    }
}