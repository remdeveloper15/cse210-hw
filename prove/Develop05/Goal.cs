
using System.ComponentModel;

public class Goal
{
    private string _shortName;
    private string _description;
    protected string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public Goal()
    {
        
    }

    public string GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"You have earned {_points} points!");
        Console.WriteLine("");
    }
    
    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }

    public virtual string GetDetailsString2()
    {
        return $"{_shortName}";
    }

    public virtual string GetStringRepresentation()
    {
        return $":{_shortName},{_description},{_points}";
    }

    public static implicit operator Goal(string v)
    {
        throw new NotImplementedException();
    }
}