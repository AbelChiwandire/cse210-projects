// Class: DueDate

using System;

public class DueDate
{
    private DateTime _dueDate;

    public DueDate(DateTime dueDate)
    {
        _dueDate = dueDate;
    }

    public bool IsOverdue()
    {
        return DateTime.Now > _dueDate;
    }

    public int DaysRemaining()
    {
        return (int)(_dueDate - DateTime.Now).TotalDays;
    }

    public string GetStatus()
    {
        int days = DaysRemaining();
        if (days > 0)
            return $"{days} day{(days == 1 ? "" : "s")} left";
        else if (days == 0)
            return "Due today";
        else
            return $"{Math.Abs(days)} day{(Math.Abs(days) == 1 ? "" : "s")} overdue";
    }

    public string GetFormattedDate()
    {
        return _dueDate.ToString("yyyy-MM-dd");
    }
}
