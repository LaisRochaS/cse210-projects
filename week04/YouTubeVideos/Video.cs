public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    private int _likes;
    private int _dislikes;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }


    public List<Comment> Comments
    {
        get { return _comments; }
        set { _comments = value; }
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

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
        _likes = 0;
        _dislikes = 0;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Like()
    {
        _likes++;
    }

    public void Dislike()
    {
        _dislikes++;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine($"Likes: {_likes} | Dislikes: {_dislikes}");  

        foreach (var comment in _comments)
        {
            Console.WriteLine($"- Comment by {comment.Author}: {comment.Text}");
            Console.WriteLine($"  Likes: {comment.Likes} | Dislikes: {comment.Dislikes}"); 
        }
        Console.WriteLine(); 
    }
}

