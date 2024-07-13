public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You have earned {_points} points!");
        Console.WriteLine("");

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $",{_isComplete}";
    }

}