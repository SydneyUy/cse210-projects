public class SimpleGoal : Goal
{
    protected bool _IsComplete;

    public SimpleGoal(string name, string description, string points) : base(name,description,points)
    {
        _IsComplete = false;
    }

    public override void RecordEvent()
    {
        _IsComplete = true;
        Console.WriteLine(_points);
    }

    public override bool IsComplete()
    {
        return _IsComplete;
    }

    public override string GetStringRepresentation()
    {
        return$"SimpleGoal:{_shortname},{_description}-{_points}";
    }
}