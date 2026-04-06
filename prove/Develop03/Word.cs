class Word
{
    private string _word;
    private bool _isHidden = false;

    public Word(string word)
    {
        _word = word;
    }
    public string GetWord()
    {
        if (_isHidden == true)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool CheckHiddenStatus()
    {
        return _isHidden;
    }
}
