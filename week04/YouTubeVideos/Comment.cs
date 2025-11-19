class Comment
{
    private string _name;
    private string _text;

    public Comment(string name,string text)
    {
      _name = name;
      _text = text;
    }

    public string getDisplayText()
    {
      return $"{_name}\n {_text}";
    }
}