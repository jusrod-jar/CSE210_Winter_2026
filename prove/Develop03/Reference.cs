public class Reference
{
    string _filename = "bom.csv";
    string _reference;
    string _book;
    int _chapter;
    int _startVerse;
    int _endVerse;
    
    public Reference()
    {
        
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public Reference(string book, int chapter, int startVerse)
    {
        
    }
    public void DisplayReference()
    {
        Console.WriteLine(_reference);
    }
}