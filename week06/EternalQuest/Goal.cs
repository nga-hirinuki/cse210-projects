using System.ComponentModel;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _shortName;
    }
    public void SetName(string shortName)
    {
        _shortName = shortName;
    }
     public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
     public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }

    public abstract int RecordEvent();


    public abstract Boolean IsComplete();
   

    public virtual string GetDetailsString()
    {
        return "details";
    }

    public abstract string GetStringRepresentation();
   

}