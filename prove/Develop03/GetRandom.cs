public class GetRandom
{
    string _filename = "bom.csv";
    string _scripture;
    string _book;
    int _chapter;
    int _reference;
    string _verse;
    public GetRandom()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);

        Random random = new Random();
        int intIndex = random.Next(lines.Length);
        string line = lines[intIndex];
        
        string[] parts = line.Split(",");

        _book = parts[0];
        _chapter = int.Parse(parts[1]);
        _reference = int.Parse(parts[2]);
        string quotedVerse = parts[3];
        _verse = quotedVerse.Replace("\"", "");   

        _scripture = CompileScripture(_book, _chapter, _reference, _verse);
    }
    
    private string CompileScripture(string book, int chapter, int reference, string verse)
    {
        string scripture = $"\n{book} {chapter}:{reference} {verse}";
        return scripture;
    }
    public string GetRandomScripture()
    {
        return _scripture;
    }
}