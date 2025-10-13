public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private DueDate _dueDate;

    // Updated constructor to include DueDate
    public ChecklistGoal(string name, string description, int points, int target, int bonus, DueDate dueDate, int amountCompleted = 0)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
        _dueDate = dueDate;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
            return _points + _bonus;
        return _points;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName}: {_description} -- Completed {_amountCompleted}/{_target} (Due: {_dueDate.GetStatus()})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_dueDate.GetFormattedDate()}|{_amountCompleted}";
    }
}
