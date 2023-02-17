public class MathAssigment : Assigments
{
    
    private string _textbookSection;
    private string _problems;

    public MathAssigment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection=textbookSection;
        _problems=problems;
    }

    public string getTextbookSection()
    {
        return _textbookSection;
    }
    public string getHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }
}
