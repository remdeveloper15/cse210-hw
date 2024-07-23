public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment>();
    

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void DisplayVideos()
    {
            Console.WriteLine($"Video: {_title}, By: {_author}, Duration: {_length} seconds");
    }

    public void DisplayComment()
    {

        int count = 0;
        
        foreach (Comment comment in _comments)
        {
            count += 1;
            Console.Write("     " + count + ". ");
            comment.DisplayComment();
        }

        Console.WriteLine("");
        Console.WriteLine($"There are {count} comments in the '{_title}' video");
        
    }
}