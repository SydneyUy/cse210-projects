public abstract class Goal
{
    protected string _shortname;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;

    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {   
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortname}-{_description}";
    }

    public abstract string GetStringRepresentation();

    public string GetPoints()
    {
        return _points;
    }
}