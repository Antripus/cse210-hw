public class Assigments
{
    private string _studentName;
    private string _topic;



    public Assigments(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string getSummary()
    {
        return _studentName + " " + _topic;
    }

    public string getStudentName ()
    {
        return _studentName;
    }
}