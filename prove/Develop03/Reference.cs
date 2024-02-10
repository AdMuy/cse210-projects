public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;


    public Reference()
    {
      
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;  
        _endVerse = endVerse;
    }

    // Displays the variables in the following like "Proverbs 3:5-6"
    public string GetDisplayText()
        {
            if (_endVerse == null)
            {
                return ($"{_book} {_chapter}:{_verse}");    
            }
            else
            {
                return ($"{_book} {_chapter}:{_verse}-{_endVerse}");
            }
        }

}