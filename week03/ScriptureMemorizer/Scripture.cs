class Scripture
{
    private Reference _reference;
    private  List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] pieces = text.Split(' ');

        foreach (string piece in pieces)
        {
            _words.Add(new Word(piece));
        }

    }


    public void HideRandomWords(int numberToHide)
    { 
       Random rand = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
       string words = string.Join(" ", _words.Select(w => w.GetDisplayText()));
       return _reference.GetDisplayText() + words + "\n";
    }
    
    public bool IsCompletelyHidden()
    {
      foreach (Word w in _words)
        {
            if (!w.isHidden())
                return false;
        }

        return true; 
    }
}