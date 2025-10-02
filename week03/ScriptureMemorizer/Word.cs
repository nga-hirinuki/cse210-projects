
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }  

    public bool IsHidden() // set to false
    {
        return _isHidden;
    }

    public void Hide() //words hidden
    {
        _isHidden = true;
    }

    public void Show() // words shown
    {
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}