using System.Linq;
public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words ;

     
    
    public Scripture (Reference reference, string text)
    {
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        // List<string> splitWord = text.Split(' ').ToList();
        // foreach(string word in splitWord)
        // {
        //     Word wordAdd = new Word(word);
        //     _words.Add(wordAdd);
        //     wordAdd.GetDisplayText();
        // }
        _reference = reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();

        // _words.Where
    }

    public string GetDisplayText()
    {
        int i = 0;
        int listLenght = _words.Count;
        while (i != listLenght)
        {
            string combinedString = string.Join( ",", _words[0].GetDisplayText());
            i++;
        }
        
        return ($"{combinedString} {_reference.GetDisplayText()}");
        //   string.Join(" ", _words.Select(word => word.ToString()));
        // var listItem = _words.GetDisplayText(); // first item of list
        // string value = ;
        
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

}