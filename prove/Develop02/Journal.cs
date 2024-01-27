using System.ComponentModel;
using System.IO; 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
            {
                entry.Display();
            }
    }

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
    
    public Journal LoadFromFile(string file)
    {
        Journal journal1 = new Journal();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            // int i = 0;
            Entry newEntry = new Entry();
            string[] parts = line.Split("~");
            
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            // And then have the loaded parts be added to the live
            // So if Displayed is called after that, the correct lines appear.;
            journal1.AddEntry(newEntry);
        }  
          return journal1;
    }
}

