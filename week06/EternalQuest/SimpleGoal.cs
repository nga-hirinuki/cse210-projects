public class SimpleGoal : Goal
{
    protected Boolean _isComplete;

    public Boolean GetIsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(Boolean isComplete)
    {
        _isComplete = isComplete;
    }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

      public override int RecordEvent()
    {
        // if we previously were not complete,
        // then mark complete and return points
        //what ifwe previously were complete?
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints(); // award points only the first time
        }
        else
        {
            return 0; // already complete, no extra points
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation()
    {
        // Format: SimpleGoal|Name|Description|Points|IsComplete
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
       
    }
}