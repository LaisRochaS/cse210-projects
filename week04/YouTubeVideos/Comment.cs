public class Comment
{
    private string _author;
    private string _text;
    private int _likes;
    private int _dislikes;

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }

    public int Likes
    {
        get { return _likes; }
        set { _likes = value; }
    }

    public int Dislikes
    {
        get { return _dislikes; }
        set { _dislikes = value; }
    }

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
        _likes = 0;
        _dislikes = 0;
    }

    public void Like()
    {
        _likes++;
    }

    public void Dislike()
    {
        _dislikes++;
    }
}
