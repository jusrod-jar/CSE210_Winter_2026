class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public string DisplayScripture()
    {
        string text = "";

        for (int i = 0; i < _words.Count(); i++)
        {  
            text +=  _words[i].GetWord() + " ";
        }

        return $"{_reference.GetReference()} {text}";
    }

    public void HideRandomWords(int numToHide)
    {
        int wordsHidden = 0;
        for (int i = 0; i < 2; i++)
        {
            while (wordsHidden < numToHide && IsAllHidden() == false)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, _words.Count());

                if (_words[randomIndex].CheckHiddenStatus() == false)
                {
                    wordsHidden++;
                    _words[randomIndex].Hide();
                }
            }
        }
    }


    public void SetRandomScripture()
    {
        _words.Clear();

        string[] lines = System.IO.File.ReadAllLines("bom.csv");

        Random random = new Random();
        int i = random.Next(0, lines.Length);
        string[] parts = lines[i].Split(",");

        _reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
        TextToWords(parts[3]);
    }

    private void TextToWords(string text)
    {
        string trimmed = $"{text.Trim("\"")}";
        string[] parts = trimmed.Split(" ");

        for (int i = 0; i < parts.Count(); i++)
        {
            Word word = new Word(parts[i]);
            _words.Add(word);
        }
    }
    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
            if (word.CheckHiddenStatus() == false)
            {
                return false;
            }
        }
        return true;
    }
}