public class Menu
{
    private List<string> mainMenu, createGoalMenu;
    private int menuSelector;


    public Menu ()
    {
        mainMenu = new List<string>{
        "Menu Option: ",
        "1. Create new goal ",
        "2. List Goals ",
        "3. Save Goals ",
        "4. Load Goals ",
        "5. Record Event ",
        "6. Quit "
        };

        createGoalMenu = new List<string>{
        "Select the tyoe of Goal:",
        "1. Simple Goal ",
        "2. Eternal Goal ",
        "3. CheckList Goal "
        };
    }


    public void displayMainMenu(){
        foreach (string menuItem in mainMenu){
            Console.WriteLine(menuItem);
        }
    }

    public void displayPoints(int totalPoints){
        Console.WriteLine(string.Format($"You have {totalPoints} points. "));
    }

    public void displayLevelUP(int totalPoints, int level, int totalPointsNextLevel){

        Console.WriteLine(string.Format($"Congrats!! You Level Up to Level {level} with {totalPoints} points. You need {totalPointsNextLevel} points for next Level"));
    }

    public int displayGetMainMenu(){
        Console.Write("select a choice from the Menu ");
        int answer = int.Parse(Console.ReadLine());
        return answer;
    }

    public int getMainMenuSelector(){
        return menuSelector;
    }

    public int DisplayGetCreateNewGoalMenu(){
        foreach (string menuItem in createGoalMenu){
            Console.WriteLine(menuItem);
        }

        Console.Write("Select a choice from the menu: ");
        int answer = int.Parse(Console.ReadLine());
        return answer;
    }
}
