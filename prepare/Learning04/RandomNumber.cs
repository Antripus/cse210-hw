public class RandomNumber
{
    private Random random;

    public RandomNumber()
    {
        random = new Random();
    }
    public int Get() => random.Next();
}