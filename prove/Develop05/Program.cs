using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your name: ");
        string name = Console.ReadLine();
        User usuario = new User(name);

        int option = 0;
        
        while (option != 6)
        {
            Menu menu = new Menu();
            Console.Write(name + " ");
            menu.displayPoints(usuario.GetTotalPoints());
            // menu.displayLevelUP(usuario.GetTotalPoints,usuario.getLevel())
            menu.displayMainMenu();
            option = menu.displayGetMainMenu();

            switch (option)
            {
                case 1:
                    int createNewOption = menu.DisplayGetCreateNewGoalMenu();
                    Goal goal = null;
                    string nameGoal, description;
                    int points;

                    switch (createNewOption){
                        case 1: 
                            
                            Console.WriteLine("What is the name of the Goal? ");
                            nameGoal = Console.ReadLine();
                            Console.WriteLine("What is a short description of the Goal? ");
                            description = Console.ReadLine();
                            Console.WriteLine("What is the amount of points for this Goal? ");
                            points = int.Parse(Console.ReadLine());
                            goal = new SimpleGoal(nameGoal, description, points, false);
                            break;
                        case 2:
                            Console.WriteLine("What is the name of the Goal? ");
                            nameGoal = Console.ReadLine();
                            Console.WriteLine("What is a short description of the Goal? ");
                            description = Console.ReadLine();
                            Console.WriteLine("What is the amount of points for this Goal? ");
                            points = int.Parse(Console.ReadLine());
                            goal = new EternalGoal(nameGoal,description,points, false, 0);
                            break;
                        case 3:
                            Console.WriteLine("What is the name of the Goal? ");
                            nameGoal = Console.ReadLine();
                            Console.WriteLine("What is a short description of the Goal? ");
                            description = Console.ReadLine();
                            Console.WriteLine("What is the amount of points for this Goal? ");
                            points = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many times this Goal need to be accomplish for the Bonus? ");
                            int timesForBonus  = int.Parse(Console.ReadLine());
                            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                            int bonusPoint = int.Parse(Console.ReadLine());
                            //public CheckListGoal(string name, string description, int points, bool complete, int timesDone, int bonusPoint, int timesForBonus)
                            goal = new CheckListGoal(nameGoal,description,points,false,0, timesForBonus ,bonusPoint);
                            break;
                    }
                
                    if (goal != null){
                        usuario.addGoal(goal);
                    }
                break;
                case 2: //List Goals
                    usuario.DisplayGoals();
                break;
                case 3://Save Goals
                    usuario.SaveGoals();
                break;
                case 4://Load Goals
                    usuario.LoadGoals();
                break;
                case 5: //record Event
                    usuario.DisplayGoalsRecordEvent();
                break;
                
            }

        }


    }
}