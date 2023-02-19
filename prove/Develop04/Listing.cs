public class Listing : Activity
{


    private List<string> _randomQuestion;
    private List<string> _answers;

    public Listing(string nameActivity, string description, string finalMessage, List<string> randomQuestion) : base ( nameActivity,  description,  finalMessage)
    {
        _randomQuestion = randomQuestion;
        
    }


    public string getOneRandomQuestion()
    {
        Random rnd = new Random ();
        int randomIndex = rnd.Next(0,_randomQuestion.Count());
        
        return _randomQuestion[randomIndex];
    }
    
    public void setAnswers(List<string> answers)
    {
        _answers = answers;
    }

    public void displayAnswers()
    {
        Console.WriteLine("Answers: ");
        int i=0;
        foreach (string a in _answers)
        {
            i++;
            Console.Write($"{i}- ");
            Console.WriteLine(a);
        }
    }
}