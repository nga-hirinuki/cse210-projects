public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        return;

    }
     public override int RecordEvent()
    {
        return 0;
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        // Customize this string as needed for your app
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}