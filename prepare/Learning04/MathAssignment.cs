public class MathAssignment : Assignment
{
    protected string _textbookSection;
    protected string _problems;

    public MathAssignment(string textbookSection, string problems, string studentName, string topic)
        :base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }
}