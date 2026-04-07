class Video
{
    private List<Comment> _comments = new List<Comment>();
    private Random random = new Random();
    private string _title;
    private string _author;
    private int _length;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        AssembleComments();
    }
    private void AssembleComments()
    {
        GetRandom getRandom = new GetRandom();
        int amountOfComments = random.Next(3, 5);

        for (int i = 0; i < amountOfComments; i++)
        {
        (string author, string content) = getRandom.GetRandomComment();
        Comment comment = new Comment(author, content);
        _comments.Add(comment);
        }
    }

    public int GetNumOfComments()
    {
        return _comments.Count();
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"\n{"Video Author:", -14} {_author}\n{"Video Title:", -14} {_title}\n{"Video Length:", -14} {_length}\n{"Comment Count:", -14} {GetNumOfComments()}\n");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
    
}