


public class JournalEntry
{

    public JournalEntry(){

    }
    
    public static void regestryJournal (string newfilename, string dateText, string promt, string answer){
        //Create the file with append option
        using (StreamWriter outputFile = new StreamWriter(newfilename, append: true))
        {
            outputFile.WriteLine($"Date: {dateText} - Promt: {promt} ");
            outputFile.WriteLine($"{answer}");
        }
    }

    
    public static string obtainDateTextNow () {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
    
    public static List<String> generatePromtList () {
        List<string> promts = new List<string>();   
        promts.Add("What was the best part of my day?");
        promts.Add("What was I learn today?");
        promts.Add("Who take my attention today?");
        promts.Add("Something surprise me today?");
        promts.Add("How I see the hand of the lord today?");

        return promts;
    }

    public static String askPromt(List<string> promts)
    {
        var random = new Random(); 
        int index = random.Next(promts.Count);
        string promt = promts[index];
        Console.WriteLine(promt);

        return promt;
    }
    
}