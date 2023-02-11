public class Video 
{

    private string _title;
    private string _author;
    private int _seconds;
    private List<Comments> _comment = new List<Comments> ();

    public Video(string title, string author, int seconds)
    {
        _author = author;
        _title = title;
        _seconds = seconds;
    }

    public Video(string title, string author, int seconds, List<Comments> comments)
    {
        _author = author;
        _title = title;
        _seconds = seconds;
        _comment = comments;
    }

    public int getNumberOfComments(){
        return _comment.Count();
    }
    public void displayComments()
    {
        int cont = 0;
        foreach (Comments com in _comment)
        {
            cont = cont +1;
            Console.WriteLine($"{cont} - Name: {com.getName()} / Comment: {com.getComment()}");
        }
    }

    public void addComment (string name, string comment)
    {
        Comments com = new Comments(name,comment);
        _comment.Add(com);
    }

    public string getAuthor ()
    {
        return _author;
    }

    public string getTitle ()
    {
        return _title;
    }
    public int getSeconds ()
    {
        return _seconds;
    }

}