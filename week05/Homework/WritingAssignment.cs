public class WritingAssignment : Assignment
{
    private string _title = "";
    private string _dueDate = "";

    public WritingAssignment(string name, string topic, string title, string dueDate) : base(name, topic)
    {
        _title = title;
        _dueDate = dueDate;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetDueDate()
    {
        return _dueDate;
    }
    public void SetDueDate(string dueDate)
    {
        _dueDate = dueDate;
    }
    public string GetWritingInfo()
    {
        return $"{GetSummary()}, Title: {_title}, Due Date: {_dueDate}";
    }
}   