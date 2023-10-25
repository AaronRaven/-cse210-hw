public class Scripture
{
    private string _reference;
    private List<Word> _words;
    private List<int> _wordsDisplayed;
    private bool _isFullyHidden;


    public Scripture(string reference, string verse)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = verse.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }

        _wordsDisplayed = new List<int>();
        for (int i = 0; i < _words.Count(); i++)
        {
            _wordsDisplayed.Add(i);
        }
        _isFullyHidden = false;
    }

    public string GetRenderedText()
    {
        string renderedText = _reference + " ";
        foreach (Word word in _words)
        {
            renderedText += word.GetWord() + " ";
        }
        return renderedText;
    }

    public void HideWords()
    {
        for (int i = 0; i < 3; i++) 
        {
            Random random = new Random();
            int choice = random.Next(_wordsDisplayed.Count());
            int index = _wordsDisplayed[choice];
            _words[index].Hide();
            _wordsDisplayed.RemoveAt(choice);
            if(_wordsDisplayed.Count() == 0)
            {
                _isFullyHidden = true;
                break;
            }
        }
    }

    public bool GetIsFullyHidden()
    {
        return _isFullyHidden;
    }
}