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

        int hiddenCount = 0;
        int indexWords = random.Next(0, _words.Count);
        int numberOfWords = _words.Count();
        if (numberToHide < numberOfWords)
        {
            while (hiddenCount < numberToHide)
            {
                if (_words[indexWords].IsHidden() == false)
                {
                    _words[indexWords].Hide();
                    hiddenCount++;
                }
                else
                {
                indexWords = random.Next(0, _words.Count);
                }
                numberOfWords = numberOfWords - numberToHide;
            } 
        }
        else 
        {
            hiddenCount = numberOfWords;
            while (hiddenCount < numberToHide)
            {
                if (_words[indexWords].IsHidden() == false)
                {
                    _words[indexWords].Hide();
                    hiddenCount++;
                }
                else
                {
                indexWords = random.Next(0, _words.Count);
                }
            } 
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