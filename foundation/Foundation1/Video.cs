public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _commentList.Count;
    }

    public string GetDisplayText()
    {
        return $"Titulo: {_title} - Author: {_author} - Length: {_length}";
    }

    public string GetDisplayComments()
    {
        string result = "Comments:\n";
        foreach (Comment comment in _commentList)
        {
            result += $"{comment.GetDisplayTextComments()}\n";
        }
        return result;
    }
}

