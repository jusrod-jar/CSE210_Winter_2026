public class Scripture
{
    string _scripture;
    public Scripture()
    {
        GetRandom random = new GetRandom();
        _scripture = random.GetRandomScripture();
    }
    public string GetScripture()
    {
        return _scripture;
    }
}