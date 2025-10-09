using System.Collections.Generic;

public class Video
{
    // Backing fields for the properties.
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    // Constructor to initialize the Video object.
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Expanded property for Title.
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    // Expanded property for Author.
    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    // Expanded property for Length (in seconds).
    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    // Attaches the list of comments for the video
    public List<Comment> Comments
    {
        get { return _comments; }
    }

    // Method to return the number of comments.
    public int GetCommentCount()
    {
        return _comments.Count;
    }
}
