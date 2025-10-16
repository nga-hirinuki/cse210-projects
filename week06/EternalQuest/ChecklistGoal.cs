using System.Runtime;

public class ChecklistGoal : Goal 
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void GetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    
    public override int RecordEvent()
    {
        // Increment progress
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }

        // Return points + bonus if completed
        if (IsComplete())
        {
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {GetName()} - {GetDescription()}| {_amountCompleted}/{_target} | {_bonus}|";
    }

    public override string GetStringRepresentation()
    {
        // Customize this string as needed for your app
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}