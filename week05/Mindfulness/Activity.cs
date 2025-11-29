class Activity
{
    protected string _name;
    protected string _description;
    protected string _duration;

    public Activity(string name,string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n---{_name} ---");
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWelldone!");
        Console.WriteLine($"\nYou commpleted {_duration} seconds of the {_name}");
        ShowSpinner(2);
        Console.WriteLine("\nGoing back to Menu..");
        ShowSpinner(2);
    }

    public void ShowSpinner(int seconds)
    {
    
        List<string> animationStrings = new List<string>
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\"
        };

        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            for (int i = 0; i < animationStrings.Count; i++)
            {
                if ((DateTime.Now - startTime).TotalSeconds >= seconds)
                {
                    break; 
                }

                Console.Write(animationStrings[i]);

                Thread.Sleep(940);

                Console.Write("\b");
            }
        }
        Console.Write("\n");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 5; i > 0; i--)
        {
         Console.Write(i);
         Thread.Sleep(1000);
         Console.Write("\b \b");
        }
    }
}