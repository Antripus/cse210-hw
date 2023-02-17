using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        
        Console.WriteLine();
        // RandomNumber random = new();
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine(random.Get());
        // }

        Assigments assigment = new Assigments("Samuel Bennet","Multiplication");

        Console.WriteLine(assigment.getSummary());
        
        Console.WriteLine();
        MathAssigment math = new MathAssigment("Roberto Rodriguez", "Fractions","Section 7.3","Problems 8-19");

        Console.WriteLine(math.getSummary());
        Console.WriteLine(math.getHomeworkList());

        Console.WriteLine();
        WritingAssigment writing = new WritingAssigment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        
        Console.WriteLine(writing.getSummary());
        Console.WriteLine(writing.getWrittingInformation());
        
        Console.WriteLine();
    }
}