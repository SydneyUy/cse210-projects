public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
      
    }

    public void DisplayAll()
    {
      string filename = Console.ReadLine();
      string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.Write(line);
        }
    }

    public void SavetoFile(string file)
    {

    }
    
    public void LoadFromFile(string file)
    {
     
    }
}