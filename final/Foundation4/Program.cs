using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");


        // Once you have the classes in place, write a program that creates at least one activity of each type. 
        // Put each of these activities in the same list. Then iterate through this list and call the method on 
        // each item and display the results.GetSummary

        // In addition, your program must:

        // Use inheritance to avoid duplicating shared attributes and methods.
        // Use method overriding for the calculation methods.
        // Follow the principles of encapsulation, making sure each member variable is private.

        
        Running running = new Running("23 Oct 2022", 15, 7);
        Cycling cycling = new Cycling("11 Sep 2023", 10, 12);
        Swimming swimming = new Swimming("12 Feb 2023", 20,6);

        List<Activity> actividades = new List<Activity>();

        actividades.Add(running);
        actividades.Add(cycling);
        actividades.Add(swimming);


        Console.WriteLine();
        Console.WriteLine("List of Activities: ");
        foreach (Activity a in actividades)
        {
            Console.WriteLine(a.getSummary());
        }
        Console.WriteLine();



    }
}