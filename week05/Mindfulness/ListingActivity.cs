class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "")
    {
        
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine("How long would you like this activity to be?");
        _duration = Console.ReadLine();
        int seconds = int.Parse(_duration);

        ShowSpinner(2);

        Console.WriteLine("\nThink carefully on the prompt below: ");
        GetRandomPrompt();
        Console.WriteLine("\nWhen you are ready to begin, press ENTER.");
        Console.ReadLine();

        ShowSpinner(2);

        List<string> userItems = GetListFromUser();

        ShowSpinner(2);
        Console.WriteLine($"You have listed {userItems.Count} items.");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);

        Console.WriteLine($"{_prompts[index]}");
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        
        int durationSeconds = int.Parse(_duration);

        DateTime end = DateTime.Now.AddSeconds(durationSeconds);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        return items;
    }
}