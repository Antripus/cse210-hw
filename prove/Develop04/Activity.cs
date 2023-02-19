public class Activity
{
    private string _nameActivity;
    private string _description;
    private string _finalMessage;

    private int _duration;
    private int _numberOfActivities;
    
    public Activity()
    {

    }

    public Activity(string nameActivity, string description, string finalMessage, int duration, int promt)
    {
        _nameActivity = nameActivity;
        _description = description;
        _finalMessage = finalMessage;
        _duration = duration;
        _numberOfActivities = 0;

    }
    public Activity(string nameActivity, string description, string finalMessage)
    {
        _nameActivity = nameActivity;
        _description = description;
        _finalMessage = finalMessage;
    }

    public void setDuration (int duration)
    {
        _duration =duration;
    }
    public void addNumberOfActivities ()
    {
        _numberOfActivities =_numberOfActivities+1;
    }
    public string getNameActivity ()
    {
        return _nameActivity;
    }
    public string getDescription ()
    {
        return _description;
    }
       public string getFinalMessage ()
    {
        return _finalMessage;
    }

    public int getDuration ()
    {
        return _duration;
    }

    public void displayActivitiesDone()
    {
        Console.WriteLine ($"Activity: {_nameActivity} - Number of Activities: {_numberOfActivities}");
    }
}