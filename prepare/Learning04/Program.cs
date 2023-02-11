using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        RandomNumber random = new();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(random.Get());
        }
    }
}