// Creates a class to save and display the entries in the journal.
public class Entry
{
    // Creates a string for all of the Entry elements.
    public string _date;
    public string _promptText;
    public string _entryText;

    // Creates a method to display the Entry elements in a specific order.
     public void Display()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_promptText} \n{_entryText}\n");
        }
}