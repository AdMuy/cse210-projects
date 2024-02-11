using System.Linq;
public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words ;

     
    
    public Scripture (Reference reference, string text)
    {
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _reference = reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        int numberOfWords = random.Next(numberToHide, _words.Count);
        int indexWords = random.Next(0, _words.Count);

        // int alreadyHidden = 0;
        // if (alreadyHidden == _w)
        for (int i = 0; i < numberOfWords; i++)
        {
            _words[indexWords].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        for (int i = 0; i < _words.Count; i++) 
        {
            displayText = displayText + _words[i].GetDisplayText() + " ";
        }
        return ($"{_reference.GetDisplayText()} {displayText}");
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = _words.All(word => word.IsHidden());
        
        if (allHidden == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}