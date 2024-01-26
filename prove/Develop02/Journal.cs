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
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText} \n{entry._entryText}\n"+"~");
            }
        }
    }
    
    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            int i = 0;
            string[] parts = line.Split("~");
            Console.WriteLine(parts[i]);
            // And then have the loaded parts be added to the live
            // So if Displayed is called after that, the correct lines appear.
        }
    }
}

