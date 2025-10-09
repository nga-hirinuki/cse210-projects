// declare a namespace
public class Comment
{
    // member variables
    private string _commenter;
    private string _text;

    // constructor
    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;  
    }

    // member methods
    public string commenter
    {
        get { return _commenter; }
        set { _commenter = value; }
    }

    public string text
    {
        get { return _text; }
        set { _text = value; }
    }
}// define a class