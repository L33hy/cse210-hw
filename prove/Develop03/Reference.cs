// Class to represent a scripture reference
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Constructor for a verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Constructor for a single verse
    public Reference(string referenceText)
    {
        string[] parts = referenceText.Split(' ');
        _book = parts[0];
        string[] chapterVerse = parts[1].Split(':');
        _chapter = int.Parse(chapterVerse[0]);
        string[] verses = chapterVerse[1].Split('-');
        _verse = int.Parse(verses[0]);
        if (verses.Length > 1)
            _endVerse = int.Parse(verses[1]);
        else
            _endVerse = 0;
    }
    
    // Get the display text of the reference
    public string GetDisplayText()
    {
        if (_endVerse == 0)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}