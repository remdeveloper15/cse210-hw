public class Book 
{
    protected string _author;
    protected string _title;

    public Book()
    {
        _author = "Anonymus";
        _title = "Unknown";
    }

    public Book(string author, string title)
    {
        _author = author;
        _title = title;
    }

    public string GetBook()
    {
        return $"{_title} by {_author}";
    }

    public string GerAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetTittle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
}