public class SimpleGoal : Goal
{
    private bool _isComplete;
    private DueDate _dueDate;

    // Updated constructor to include DueDate
    public SimpleGoal(string name, string description, int points, DueDate dueDate, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
        _dueDate = dueDate;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_shortName}: {_description} (Due: {_dueDate.GetStatus()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_dueDate.GetFormattedDate()}|{_isComplete}";
    }
}
