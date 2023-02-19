public class Reflection : Activity
{

    private List<string> _randomQuestion = new List<string>();
    private List<string> _promts = new List<string>();
    private string _answer;

    public Reflection(string nameActivity, string description, string finalMessage, List<string> randomQuestion, List<string> promts) : base ( nameActivity,  description,  finalMessage)  
    {
        _randomQuestion = randomQuestion;
        _answer = "";
        _promts = promts;
    }

    public void setAnswer (string answer)
    {
        _answer = answer;
    }
    
    public List<string> getRandomQuestion ()
    {
        return _randomQuestion;
    }


    public string getOnePromt()
    {
        Random rnd = new Random ();
        int randomIndex = rnd.Next(0,_promts.Count());

        return _promts[randomIndex];
    }

    public string getOneRandomQuestion()
    {
        Random rnd = new Random ();
        int randomIndex = rnd.Next(0,_randomQuestion.Count());
        
        return _randomQuestion[randomIndex];
    }
}