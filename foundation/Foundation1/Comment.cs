public class Comment
{
    private string _nameCommentarist;
    private string _textComment;

    public Comment(string namecommentarist, string textComment)
    {
        this._nameCommentarist = namecommentarist;
        this._textComment = textComment;
    }
    public string GetDisplayTextComments()
    {
        return $"{_nameCommentarist}: {_textComment}";
    }

}