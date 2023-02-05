public class SimpleGoal : Goal 
{

    public SimpleGoal (string name, string description, int points, bool complete) : base (name, description, points) 
    {
        _complete = complete;
        _goalType = 1;
    }

    public override void displayGoal()
    {
        Console.WriteLine("MOSTRAR ETERNAL GOALS ");
    }

    public override void setComplete()
    {
        _complete = true;
    }

    public override string ToString()
    {
        string line = string.Format ("{0} | {1} | {2} | SIMPLE GOAL", ((_complete == false) ? "[ ]" : "[X]"), getGoalName(), getGoalDescription());

        return line;
    }

    public override string ToCSVRecord()
    {
        string csvRecord = string.Format ("{0}|{1}|{2}|{3}|{4}", getGoalType(), getGoalName(), getGoalDescription(), getGoalPoints() ,isCompleted());

        return csvRecord;
    }

    public override void RecordEvent(string userName)
    {
        Console.WriteLine(string.Format("{0} you have {1} Points, Congratulation", userName, getGoalPoints()));
        _complete = true;
    }
}