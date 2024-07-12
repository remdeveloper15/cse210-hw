public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _problems = problems;
        _textbookSection = textbookSection;
    }

    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }
}