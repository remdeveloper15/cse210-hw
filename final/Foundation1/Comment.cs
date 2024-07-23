public class Comment 
{
    private string _userComment;
    private string _textComment;

    public Comment(string userComment, string textComment)
    {
        _userComment = userComment;
        _textComment = textComment; 
    }
    public void DisplayComment()
    {
        Console.WriteLine($"User: {_userComment}, Comment: {_textComment}");
    }
}