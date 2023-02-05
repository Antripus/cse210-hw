public abstract class Goal
{

    public bool _complete;
    private string _name, _description;
    private int _points;
    public int _goalType;

    public Goal (string name, string descriptiion, int points){ //Cosntructor

        _complete = false;
        _name = name;
        _description = descriptiion;
        _points = points;

    }

    public bool isCompleted()
    {
        return _complete;
    }
    public string getGoalName(){
        return _name;
    }
    public string getGoalDescription(){
        return _description;
    }
    public int getGoalType(){
        return _goalType;
    }

    public int getGoalPoints(){
        return _points;
    }
    public abstract void setComplete();
    public abstract void displayGoal();

    public abstract string ToString();
    public abstract string ToCSVRecord();
    public abstract void RecordEvent(string userName);
}

