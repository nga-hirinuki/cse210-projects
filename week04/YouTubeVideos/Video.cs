
public class Video
{
    // member variables
    private string _title;
    private string _author;
    private int _length; // in seconds
    private List<Comment> _comments;

    // constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // member methods
    public string title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int length
    {
        get { return _length; }
        set { _length = value; }
    }

    public List<Comment> comments
    {
        get { return _comments; }
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}