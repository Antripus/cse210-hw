using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");


        List <string> mainMenu = new List<string>{
            "Menu Option: ",
            "1. Start breathing activity ",
            "2. Start reflecting activity ",
            "3. Start listing activity ",
            "4. Show how many activities was done ",
            "5. Show submited Answers ",
            "6. Quit ",
            };
 
        string option = "0";
        
        // Console.Write("+");

        // Thread.Sleep(500);

        // Console.Write("\b \b"); // Erase the + character
        // Console.Write("-"); // Replace it with the - character


        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(5000);
        // int x = 0;
        // while (x < 10)
        //     {
        //         Thread.Sleep(1000);
        //         Console.Write("\b");
        //         Console.Write($"{x}");
            
        //         x++;
        //     }
        // DateTime currentTime = DateTime.Now;
        // Console.WriteLine(currentTime);
        // Console.WriteLine(startTime);
        // if (currentTime < futureTime)
        // {
        //     Console.WriteLine("We have not arrived at our future time yet...");
        // }
        string name = "Breathing";
        string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string finalMessage = "Well done!!!";
        Breathing breath = new Breathing(name,description,finalMessage);


        string reflectName = "Reflecting";
        string reflectDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string reflectFinalMessage = "Well done!!!";
        List <string> randomQuestion = new List<string>{
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?",
                };
        List <string> promts = new List<string>{
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless.",
                };
        Reflection reflect = new Reflection (reflectName,reflectDescription,reflectFinalMessage,randomQuestion,promts);


        string listingName = "Listing";
        string listingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string listingFinalMessage = "Well done!!!";
        List <string> listingRandomQuestion = new List<string>{
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?",
                };
        Listing listing = new Listing (listingName,listingDescription, listingFinalMessage,listingRandomQuestion);


        while (option != "6"){
            option = getOption(mainMenu);
            switch (option)
            {
                case "1": 
                    //Creo la actividad breathing con sus campos
                    

                    int duration = activityPresentation(name,description);
                    breath.setDuration(duration);
                    

                    Console.WriteLine("Get Ready ...  ");
                    charging();
                    while (duration > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Breathe in... ");
                        displayCountDown(4);
                        Console.WriteLine();
                        Console.Write("Breathe out... ");
                        displayCountDown(6);
                        Console.WriteLine();

                        duration = duration-10;
                        breath.addNumberOfActivities(); //cuento la cantidad de repeticiones
                    }
                     Console.WriteLine();
                    Console.WriteLine(breath.getFinalMessage());
                    Console.WriteLine();
                    Console.WriteLine($"You have completed another {breath.getDuration()} seconds of Breathing Activity.");
                    charging();
                    Console.WriteLine();

                break;
                case "2": 
                    

                    int reflectDuration = activityPresentation(reflectName,reflectDescription);
                    reflect.setDuration(reflectDuration);
                    
                    Console.WriteLine("Get Ready ...  ");
                    charging();
                    Console.WriteLine();


                    Console.WriteLine("Consider the following promt: ");
                    Console.WriteLine();
                    Console.WriteLine($" --- {reflect.getOnePromt()} --- ");
                    Console.WriteLine();
                    Console.WriteLine("When you have something in mind, press enter to continue: ");
                    Console.ReadLine();
                    
                    Console.WriteLine("Now ponder on each of the following questions as they related to this experience. ");
                    Console.WriteLine("You may begin in: ");
                    displayCountDown(6);

                    Console.WriteLine();
                    while (reflectDuration > 0)
                    {
                        
                        Console.WriteLine();
                        Console.Write($" >>> {reflect.getOneRandomQuestion()}  ");
                        displayCountDownSymbols(10);
                        

                        reflectDuration = reflectDuration-10;
                        reflect.addNumberOfActivities(); //cuento la cantidad de repeticiones
                    }
                    Console.WriteLine();
                    Console.WriteLine(reflect.getFinalMessage());
                    Console.WriteLine();
                    Console.WriteLine($"You have completed another {reflect.getDuration()} seconds of Breathing Activity.");
                    charging();
                    Console.WriteLine();

                break;
                case "3": 
                  

                    int listingDuration = activityPresentation(listingName,listingDescription);
                    listing.setDuration(listingDuration);
                    
                    Console.WriteLine("Get Ready ...  ");
                    charging();
                    Console.WriteLine();

                    Console.WriteLine("List as many responses you can to the following promt: ");
                    Console.WriteLine();
                    Console.WriteLine($" --- {listing.getOneRandomQuestion()} --- ");
                    Console.Write("You may begin in: ");
                    displayCountDown(6);
                    
               
                    DateTime startTime = DateTime.Now;
                    DateTime futureTime = startTime.AddSeconds(listingDuration);

                    List<string> answers = new List<string>();

                    while (futureTime > DateTime.Now)
                        {
                        Console.WriteLine();
                        Console.Write(" > ");
                        answers.Add(Console.ReadLine());
                        }
                    int items = answers.Count();
                    listing.setAnswers(answers);
                    listing.addNumberOfActivities();
                    Console.WriteLine($"You listed {items} items");
                    Console.WriteLine();
                    Console.WriteLine();
                    
                break;
                case "4": 
                    breath.displayActivitiesDone();
                    reflect.displayActivitiesDone();
                    listing.displayActivitiesDone();
                break;
                
                case "5": 
                    listing.displayAnswers();
                    
                break;
            }

        }



    }


    private static string getOption(List<string> mainMenu)
    {
        
        foreach (string m in mainMenu)
        {
            Console.WriteLine(m);
        }
        Console.Write ("Select a choice from the menu: ");
        return Console.ReadLine ();

    }

    private static int activityPresentation(string type, string description)
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {type} Activity");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
        
        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        return seconds;
    }

    private static void displayCountDown (int y)
    {
        // int x = 0;
        while (0 < y)
            {
                
                Console.Write("\b");
                Console.Write($"{y}");
                Thread.Sleep(1000);
                y--;
                if (y == 0)
                {
                    Console.Write("\b");
                    Console.Write($" ");
                }
            }
    }

    private static void displayCountDownSymbols (int y)
    {
        // int x = 0;
        while (0 < y)
            {
                
                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b");
                Console.Write("|");
                Thread.Sleep(500);
                y--;
                if (y == 0)
                {
                    Console.Write("\b");
                    Console.Write($" ");
                }
            }
    }

    private static void charging ()
    {
        string charging = "[                ]";

        int s=0;
        Console.Write(charging);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        while(s<16)
        {
            s++;
            Console.Write("/");
            Thread.Sleep(250);
        }
        Console.Write("]");
    }
}