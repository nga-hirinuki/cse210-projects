public class Comment
{
    // Backing fields for the properties.
    private string _commenter;
    private string _text;

    // Constructor to initialize the Comment object.
    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }

    // Expanded property for the name of the commenter.
    public string Commenter
    {
        get { return _commenter; }
        set { _commenter = value; }
    }

    // Expanded property for the text of the comment.
    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }
}
