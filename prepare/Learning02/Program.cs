
using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
           
        //job1.display();
        //job2.display();
   
        Resume newResume = new Resume();
        newResume._name ="Jhon Lennon";

        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);

        newResume.Display();
    }
}
