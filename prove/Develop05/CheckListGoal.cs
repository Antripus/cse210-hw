public class CheckListGoal : Goal 
{

    private int _bonusPoint, _timesForBonus, _timesDone;
    
    //getGoalType(),    getGoalName(), getGoalDescription(), getGoalPoints() ,isCompleted(),_timesDone, _timesForBonus, _bonusPoint);
    public CheckListGoal(string name, string description, int points, bool complete, int timesDone, int timesForBonus, int bonusPoint ) : base (name,  description, points)
    {
        _complete = complete;
        _bonusPoint = bonusPoint;
        _timesForBonus = timesForBonus;
        _timesDone = timesDone;
        _goalType = 3;
    }

    public override void displayGoal()
    {
        Console.WriteLine("MOSTRAR CHECKLIST GOALS ");
    }

    public override void setComplete()
    {
        _complete = true;
    }
    // public string getStatus()
    // {
    //     return string.Format("{0}/{1}",_timesDone,_timesForBonus);
    // }

    private void increaseTimesDone (){
        _timesDone = _timesDone +1;

        if (_timesDone == _timesForBonus)
            {
                setComplete();
            }
    }


    public override string ToString()
    {
        string line = string.Format ("[{0}] | {1} | {2} | {3}/{4} | {5} Bonus Points | CHECKLIST GOAL", ((_complete == false) ? " " : "X"), getGoalName(), getGoalDescription(), _timesDone, _timesForBonus, _bonusPoint);

        return line;
    }

    public override string ToCSVRecord()
    {
        string csvRecord = string.Format ("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", getGoalType(), getGoalName(), getGoalDescription(), getGoalPoints() ,isCompleted(),_timesDone, _timesForBonus, _bonusPoint);

        return csvRecord;
    }

    public override void RecordEvent(string userName)
    {
        _timesDone = _timesDone +1;
        Console.WriteLine(string.Format("{0} you have {1} Points, You did this Goal {2}/{3} times, Congratulation!!!", userName, getGoalPoints(),_timesDone,_timesForBonus));
        if (_timesDone == _timesForBonus)
        {
            _complete = true;
            Console.WriteLine(string.Format("Great Job!!! you earn {0} extra Points", _bonusPoint));
        }
    }
}
