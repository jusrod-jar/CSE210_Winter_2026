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


    public void e()
    {
        _words.Clear();

        string[] lines = System.IO.File.ReadAllLines("bom.csv");

        Random random = new Random();
        int randomScripIndex = random.Next(0, lines.Length);

        string[] verse1Parts = lines[randomScripIndex].Split(",");

        _reference = new Reference(verse1Parts[0], int.Parse(verse1Parts[1]), int.Parse(verse1Parts[2]));
        TextToWords(verse1Parts[3]);

        int determineVerseNum = random.Next(1, 3);
        if (determineVerseNum == 2)
        {
            string[] verse2Parts = lines[randomScripIndex + 1].Split(",");
            if (verse1Parts[0] == verse2Parts[0] && verse1Parts[1] == verse2Parts[1])
            {
            _reference = new Reference(verse1Parts[0], int.Parse(verse1Parts[1]), int.Parse(verse1Parts[2]), int.Parse(verse2Parts[2]));
            TextToWords(verse2Parts[3]);
            }
        }
    }

    private void TextToWords(string text)
    {
        string trimmed = $"{text.Replace("\"", "")}";
        string[] parts = trimmed.Split(" ", StringSplitOptions.RemoveEmptyEntries);

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