public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;
    private string _fullReference;
    private string _verseTextFull;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _fullReference = $"{_book} {_chapter}:{_verse}";


    }

    public Reference(string book, int chapter, int verse, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseEnd = verseEnd;
        
        _fullReference = $"{_book} {_chapter}:{_verse}-{_verseEnd}";


    public string GetFullReference()
    {
        return _fullReference;
    }

    public string GetVerseTextFull()
    {
        return _verseTextFull;
    }
}