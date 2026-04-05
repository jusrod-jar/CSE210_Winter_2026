using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
    }
}
class Comment
{
    private string _author;
    private string _content;

    public Comment()
    {
        _author = "N/A";
        _content = "N/A";
    }

    public void AssembleComment()
    {
        
    }
}
class Video
{
    private List<string> _comments = new List<string>();
    private string _title;
    private string _author;
    private int _length;

    public Video()
    {
        _title = "N/A";
        _author = "N/A";
        _length = 0;
        _comments = [];
    }

    public int GetNumOfComments()
    {
        return _comments.Count();
    }

    public string DisplayVideo()
    {
        return $"Author: {_author} ~ Title: {_title} ~ Length: {_length} ";
    }
    
}