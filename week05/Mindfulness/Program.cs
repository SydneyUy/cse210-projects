using System;

class Program
{
    static void Main(string[] args)
    {   
        string selection = "";

        while (selection != "4")
        {
            Console.Write("Menu Options:\n1.Start breathing activity\n2.Start reflecting activity\n3.Start Listing Activity\n4. Quit");
            Console.Write("\nSelect an option: ");

            selection = Console.ReadLine();

            switch(selection)
            {   
                //breathing activity
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                //reflecting activity
                case "2": 
                    ReflectingActivity reflect = new ReflectingActivity();
                    reflect.Run();
                    break;
                //Listing activity
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Ending Mindfulness program, we hope to see you again!");
                    break;
                default:
                    Console.WriteLine("\nInvalid selection. Please choose an option from 1 to 4.");
                    Thread.Sleep(1000);
                    break;
            }
        }


    }
}