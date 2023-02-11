public class Comments
{

    private string _name;
    private string _comment;

    public Comments(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string getName ()
    {
        return _name;
    }

    public string getComment ()
    {
        return _comment;
    }
}