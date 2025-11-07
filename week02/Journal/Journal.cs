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
            entry.display();
        }
    }

    public void SavetoFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file, true))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"{entry._date},{entry._promptText},{entry._entryText}";
                outputFile.WriteLine(line);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry); 
        }
        Console.WriteLine($"Loaded from file: {file}");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}