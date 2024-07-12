public class PictureBook : Book
{
    private string _illustrator;

    public PictureBook()
    {
    }
    
    public PictureBook(string author, string title, string illustrator) : base(author, title)
    {
        _illustrator = illustrator;
    }

    public string GerIllustrator()
    {
        return _illustrator;
    }

    public void SetIllustrator(string illustrator)
    {
        _illustrator = illustrator;
    }

    public string GetPictureBook()
    {
        return $"{_title} by {_author} ilustrated by {_illustrator}";
    }
}