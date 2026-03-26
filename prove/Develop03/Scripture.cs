public class Scripture
{
    string _scripture;
    public string GetNewScripture()
    {
        GetRandom random = new GetRandom();
        _scripture = random.GetRandomScripture();
        return _scripture;
    }
    // public string RemoveWords()
    // {
        
    // }
}