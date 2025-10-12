public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string name)
    {
        _studentName = name;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"Student: {_studentName}, Topic: {_topic}";
    }
}
