class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {"Think of a time when you stood up for someone else.",
     "Think of a time when you did something really difficult.",
     "Think of a time when you helped someone in need.",
     "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "")
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
        DisplayPrompt();
        Console.WriteLine("\nWhen you are ready to begin, press ENTER.");
        Console.ReadLine();

        ShowSpinner(2);

        DateTime end = DateTime.Now.AddSeconds(seconds);

        DisplayQuestions();

        ShowSpinner(2);
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
    }

    public void DisplayQuestions()
    {
        int durationSeconds = int.Parse(_duration);

        DateTime end = DateTime.Now.AddSeconds(durationSeconds);

        while (DateTime.Now < end)
        {
           string question = GetRandomQuestion();
           Console.Write($"> {question} ");
           ShowSpinner(5);
           Console.WriteLine("\n");
        }
    } 
}