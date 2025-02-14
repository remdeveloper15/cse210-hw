public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" --- Current completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $",{_bonus},{_target},{_amountCompleted}";
    }


}