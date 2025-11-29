class BreathingActivity : Activity
{
  public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly.", "")
  {

  }

  public void Run()
  {
    Console.Clear();
    DisplayStartingMessage();
    Console.WriteLine("How long would you like this activity to be?");
    _duration = Console.ReadLine();
    int seconds = int.Parse(_duration);
    Console.WriteLine($"Prepare to begin for {_duration} seconds...");
    Console.WriteLine("When you are ready to begin, press ENTER.");
    Console.ReadLine();

    ShowSpinner(2);

    DateTime end = DateTime.Now.AddSeconds(seconds);

    while (DateTime.Now < end)
    {
      Console.WriteLine("Breathe in...");
      ShowCountDown(3);

      Console.WriteLine("Breathe out...");
      ShowCountDown(3);
    }

    ShowSpinner(2);
    DisplayEndingMessage();
  }
}