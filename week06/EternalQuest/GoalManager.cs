public class GoalManager
{
    protected List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {}

    public void Start()
    {   string selection = "";

        while (selection != "6")
        {
            Console.Write("Menu Options:\n1.Create New Goal\n2.List Goals\n3.Save Goals\n4.Load Goals\n5.Record Event\n6.Quit");
            Console.Write("\nSelect a choice from the menu(input the number): ");
            //Unlike in the mindfullness activity, I think this readline is much clearer for the user.
            selection = Console.ReadLine();

            switch(selection)
            {   
                //Create New Goal
                case "1":
                 CreateGoal();
                 break;
                //List Goals
                case "2":
                 ListGoalNames();
                 ListGoalDetails();
                 break;
                //Save Goals
                case "3":
                 SaveGoals();
                 break;
                //Load Goals
                case "4":
                 LoadGoals();
                 break;
                //Record Event
                case "5":
                 RecordEvent();
                 break;
                //Quit
                case "6":
                 Console.WriteLine("Closing Program.");
                 break;
                default:
                    Console.WriteLine("\nInvalid selection. Please choose an option from 1 to 4.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
    }

    public void ListGoalDetails()
    {
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    }

    public void CreateGoal()
    {

            Console.Write("The types of goals are:\n1.Simple Goal\n2.Eternal Goal\n3.Checklist Goal");
            Console.Write("\nSelect a choice from the menu(input the number): ");
                        
            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            Console.Write("Enter points: ");
            string points = Console.ReadLine();

            if (type == 1)
                _goals.Add(new SimpleGoal(name, description, points));

            else if (type == 2)
                _goals.Add(new EternalGoal(name, description, points));

            else if (type == 3)
            {
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            }
    }

    public void RecordEvent()
    {
            Console.WriteLine("Which goal did you accomplish? (input the associated number): ");
            ListGoalNames();

            int index = int.Parse(Console.ReadLine()) - 1;
            Goal goal = _goals[index];

            int basePoints = int.Parse(goal.GetPoints());

            int earned = basePoints;

            goal.RecordEvent();

            if (goal is ChecklistGoal cg && cg.IsComplete())
                earned += cg.GetBonus();

            _score += earned;

            Console.WriteLine($"You earned {earned} points!");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine($"\nGoals successfully saved to {filename}");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
                Console.WriteLine("\nFile not found!");
                return;
        }

        string[] lines = File.ReadAllLines(filename);

         _goals.Clear();
         _score = int.Parse(lines[0]); 

        for (int i = 1; i < lines.Length; i++)
        {
           string[] parts = lines[i].Split(':');
           string type = parts[0];

                if (type == "SimpleGoal")
                {
                    SimpleGoal g = new SimpleGoal(
                        parts[1],       
                        parts[2],        
                        parts[3]       
                    );

                    bool isComplete = bool.Parse(parts[4]);
                    if (isComplete)
                        g.RecordEvent();  

                    _goals.Add(g);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal g = new EternalGoal(
                        parts[1],
                        parts[2],
                        parts[3]
                    );

                    _goals.Add(g);
                }
                else if (type == "ChecklistGoal")
                {
                    ChecklistGoal g = new ChecklistGoal(
                        parts[1],               
                        parts[2],                
                        parts[3],
                        int.Parse(parts[5]),     
                        int.Parse(parts[6])      
                    );

                    int completedCount = int.Parse(parts[4]);

                    for (int c = 0; c < completedCount; c++)
                        g.RecordEvent();

                    _goals.Add(g);
                }
                Console.WriteLine($"\nGoals successfully loaded from {filename}");
        }
    }
        
}