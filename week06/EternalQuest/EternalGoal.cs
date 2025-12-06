public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name,description,points)
    {
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine(_points);
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return$"EternalGoal:{_shortname},{_description}-{_points}";
    }
}