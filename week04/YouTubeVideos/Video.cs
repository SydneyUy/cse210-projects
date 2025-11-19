class Video
{
    private string _title;
    private string _author;
    private double _length; 
    private  List<Comment> _comment = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void addComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int getNumComments(Comment comment)
    {
        return _comment.Count;
    }

    public List<Comment> GetComments()
    {
        return _comment;
    }

    public string GetDisplayVideo()
    {
        return $"{_title}\n{_author}\n{_length}";
    }
}