using System;

class Program
{
    static void Main(string[] args)
    {
        //create this:
        //1 WRITE: needs a random prmpt and the user will answer. Maybe add all unsaved answers to a list? 
        //2 DISPLAY: you need a list. displays date, prompt and answer.
        //3 LOAD: load a journal. need use input on what is the filename
        //4 SAVE: Save everyting found on the list. ask user for the filename.
        // add to prompts?

        Console.Write("JOURNAL WRITTING\n");

        Console.Write("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");

        int Userinput = -1;
        Journal journal = new Journal();

        while (Userinput != 5)
        {
            Console.Write("Select one of the corresponding numbers:\n ");
            Userinput = int.Parse(Console.ReadLine());

            if (Userinput == 1)
            {
                Console.Write("What is your first name?");
                string userEntry = Console.ReadLine();
                Entry entry = new Entry(prompt, entry, DateTime.Now.ToString("dd/MM/yyyy"));
                Console.WriteLine(userEntry);
            else if (Userinput == 2)
            {
                journal.DisplayAll();
            }
            }
            else if (Userinput == 3)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
            }
            else if (Userinput == 4)
            {
                Console.WriteLine("D");
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