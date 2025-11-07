public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    
    
    

    public void display()
    {
        Console.WriteLine($"{_date}\n {_promptText}\n {_entryText}");
    }
}