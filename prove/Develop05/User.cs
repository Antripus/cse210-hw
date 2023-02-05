public class User
{

    private string _name;
    //private int _level;
    private List <Goal> _goals;
    public int _totalPoints;


    public User (string name){
        _name = name;
        _totalPoints = 0;
       // _level = 1;
        _goals = new List<Goal> {}; 
    }

    public void DisplayGoals()
    {
        Console.WriteLine();
        if (_goals.Count() == 0){
            Console.WriteLine ("There are no Goals created or loaded");
        }
        foreach (Goal goal in _goals){
            Console.WriteLine(goal.ToString());
        }
    }

    private void UpdatePoints (int points)
    {
        _totalPoints = _totalPoints + points;
    }

    public int GetTotalPoints (){
        return _totalPoints;
    }
    
    // public int GetLevel (){
    //     return _totalPoints;
    // }
    
    public void addGoal (Goal goal){
        _goals.Add(goal);
    }

    public void SaveGoals ()
    {
        if(_goals.Count() == 0){
            Console.WriteLine ("There are not goals to save");
            return;
        }

        string fileToSave = DisplayGetGoalFile();

        List<string> saveGoals = new List<string>();

        saveGoals.Add(_totalPoints.ToString());

        foreach(Goal goal in _goals){
            saveGoals.Add(goal.ToCSVRecord()); // Corro e metodo de cada Goal
        }

        SaveLoadCSV.SaveToCSV(saveGoals, fileToSave); //Conecto a la Clase SaveLoadCSV
        
        Console.WriteLine("Goals Saved");

    }

    public void LoadGoals ()
    {
        List<string> goalsInFile = new List<string> ();
        
        // if (File.Exists(_filepath))
        // {
        //     goalsInFile = SaveLoadCSV.LoadFromCSV(_filepath);
        // }
        // else
        // {
        goalsInFile = SaveLoadCSV.LoadFromCSV(DisplayGetGoalFile());
        // }
        _goals = new List<Goal>();

        Goal goal = null;
        int linea = 0;
        foreach (string goalLine in goalsInFile)
        {
            if (linea == 0 )
            {
                linea = linea +1;
                _totalPoints = int.Parse(goalLine.ToString());
            }
            else
            {
                linea = linea + 1 ;
                string[] goalParts = goalLine.Split('|');
                int _goalType  = int.Parse(goalParts[0]);

                switch(_goalType)
                {
                    case 1:
                        goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]),bool.Parse(goalParts[4]));
                        break;
                    case 2:
                        goal = new EternalGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]),bool.Parse(goalParts[4]),int.Parse(goalParts[5])) ;
                        break;
                    case 3:
                        goal = new CheckListGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]),bool.Parse(goalParts[4]),int.Parse(goalParts[5]),int.Parse(goalParts[6]),int.Parse(goalParts[7]));
                        break;

                }
                if (goal != null && _goals.Contains(goal) == false)
                {
                    _goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals Loaded");
    }

    public string DisplayGetGoalFile()
    {
        Console.WriteLine("Write the name of the File for the Goals: ");
        string answer = Console.ReadLine();
        return answer;
    }

    public void DisplayGoalsRecordEvent()
    {
        if (_goals.Count() == 0){
            Console.WriteLine ("There are no Goals created or loaded");
        }
        else
        {
        Console.WriteLine();
        Console.WriteLine("The Goals are: ");
        foreach (Goal goal in _goals)
        {
            switch (goal._goalType)
            {
                case 1:
                    if (goal._complete != true){ // no mostrar las Simple Goals ya realizadas
                        Console.WriteLine(string.Format("[{0}] {1}", _goals.IndexOf(goal) + 1, goal.getGoalName() ));
                    }
                    break;
                case 2:
                    //Eternal Goal
                    Console.WriteLine(string.Format("[{0}] {1}", _goals.IndexOf(goal) + 1, goal.getGoalName() ));
                    break;
                case 3:
                    //CheckList Goal
                    if (goal._complete != true){
                        Console.WriteLine(string.Format("[{0}] {1}", _goals.IndexOf(goal) + 1, goal.getGoalName() ));
                    }
                    break;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Which Goal did you accomplish? ");
        Console.WriteLine();
        int recordEvent = int.Parse(Console.ReadLine())-1;
        _goals[recordEvent].RecordEvent(_name); //override Method for each child
        _totalPoints += _goals[recordEvent].getGoalPoints();
        Console.WriteLine();

        // Console.WriteLine(string.Format("You now have {0} points", _totalPoints.ToString()));
        }
    }
}