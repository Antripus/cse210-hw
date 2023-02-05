public class EternalGoal : Goal
{

    private int _timesCompleted;


    public EternalGoal (string name, string description, int points, bool complete, int timesCompleted) : base (name,  description, points)
    {
        _timesCompleted = timesCompleted; 
        _goalType = 2;
    }

    public override void displayGoal()
    {
        Console.WriteLine("MOSTRAR ETERNAL GOALS ");
    }

    public override void setComplete()
    {
        _timesCompleted = _timesCompleted +1;
    }


    public override string ToString()
    {
        string line = string.Format ("{0} | {1} | {2} | {3} Times completed | ETERNAL GOAL", ((_complete == false) ? "[ ]" : "[X]"), getGoalName(), getGoalDescription(),_timesCompleted);

        return line;
    }

    public override string ToCSVRecord()
    {
        string csvRecord = string.Format ("{0}|{1}|{2}|{3}|{4}|{5}", getGoalType(), getGoalName(), getGoalDescription(), getGoalPoints() ,isCompleted(),_timesCompleted);

        return csvRecord;
    }

    public override void RecordEvent(string userName)
    {
        _timesCompleted = _timesCompleted + 1;
        Console.WriteLine(string.Format("{0} you have {1} Points, You did this Goal {2} times, Congratulation!!!", userName, getGoalPoints(),_timesCompleted));
    }
}