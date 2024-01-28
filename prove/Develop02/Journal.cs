using System.ComponentModel;
using System.IO; 
// A class to create a Journal with the ability to add new Entries.
// Display all of the entries in that journal.
// Load entries from a file and add them to the journal. 
// Save all of the entries in the jornal to a file.
public class Journal
{
    // Creates an Entry list for all of the different _entries the user creates.
    public List<Entry> _entries = new List<Entry>();
    // Add those entries to the Journal.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    // Displays all of the entries added to the journal.
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
            {
                entry.Display();
            }
    }
    // Loads saved entries from a file and add those 
    // entries to the journal.
    public Journal LoadFromFile(string file)
    {
        Journal journal1 = new Journal();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] parts = line.Split("~");       
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            journal1.AddEntry(newEntry);
        }  
          return journal1;
    }
    // Saves all of the entries in the journal to an external file
    // with the correct syntax so the LoadFromFile can get the information
    // in the correct order. 
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }
        }
    }   
}

