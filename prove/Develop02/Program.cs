using System;
using System.IO; 


class Program
{
    //Journal Class

    // //Save Journal
    // static void saveJournal (string newfilename, string defaultfilename) { //OK
    //     Console.WriteLine("What is the file name?");
                
    //     Console.Write("> ");
    //     string newfilename2 = Console.ReadLine();
    //     using (var reader = new StreamReader(newfilename))
    //     using (var writer = new StreamWriter(defaultfilename, append: false))
    //     {
    //         writer.Write(reader.ReadToEnd());
    //     }
    //     // I need to do 2 copies because when I try to copy a file with the same name give me an error. So I create a bridge with my default name file
    //     using (var reader = new StreamReader(defaultfilename))
    //     using (var writer = new StreamWriter(newfilename2, append: false))
    //     {
    //         writer.Write(reader.ReadToEnd());
    //     }

    // }
    // //Load Journal
    // static string loadJournal () { //OK
    //     Console.WriteLine("Load");
    //     Console.WriteLine("What is the file name?");
    //     Console.Write("> ");
    //     string newfilename = Console.ReadLine();
        
    //     return newfilename;
    // }
    // //Read Journal
    // static void readJournal (string newfilename) { //OK

    //     string[] lines = System.IO.File.ReadAllLines(newfilename);

    //     foreach (string line in lines)
    //     {
    //         Console.WriteLine($"{line}");
    //     }
    // }

    // //JournalEntry Class

    // //Save Journal
    // static void regestryJournal (string newfilename, string dateText, string promt, string answer){ //OK
    //     //Create the file with append option
    //     using (StreamWriter outputFile = new StreamWriter(newfilename, append: true))
    //     {
    //         outputFile.WriteLine($"Date: {dateText} - Promt: {promt} ");
    //         outputFile.WriteLine($"{answer}");
    //     }
    // }

    
    // //Load Journal
    // static string obtainDateTextNow () { //OK
    //     DateTime theCurrentTime = DateTime.Now;
    //     string dateText = theCurrentTime.ToShortDateString();
    //     return dateText;
    // }
    // // //Read Journal
    // static List<String> generatePromtList () {//OK
    //     List<string> promts = new List<string>();   
    //     promts.Add("What was the best part of my day?");
    //     promts.Add("What was I learn today?");
    //     promts.Add("Who take my attention today?");
    //     promts.Add("Something surprise me today?");
    //     promts.Add("How I see the hand of the lord today?");

    //     return promts;
    // }
    // static String askPromt(List<string> promts)//OK
    // {
    //     var random = new Random(); 
    //     int index = random.Next(promts.Count);
    //     string promt = promts[index];
    //     Console.WriteLine(promt);

    //     return promt;
    // }
    
    
    static void Main(string[] args) //MAIN
    {
        string defaultfilename = "myFile.txt";
        string newfilename=defaultfilename;
        int option = 0;

        
        JournalEntry journalEntry = new JournalEntry();
        Journal journal = new Journal();
        
        List<string> promts = journalEntry.generatePromtList(); // METHOD - JournalEntry

        while (option != 5 )
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1 - Write ");
            Console.WriteLine("2 - Display ");
            Console.WriteLine("3 - Load ");
            Console.WriteLine("4 - Save ");
            Console.WriteLine("5 - Quit ");

            Console.Write("> ");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (option == 1) //Write
            {
                //Console.WriteLine("Write");
                
                // Take a random index number from promts and then print in the console
               
                string promt = journalEntry.askPromt(promts); // METHOD - JournalEntry
        
                Console.Write("> ");
                string answer = Console.ReadLine();
                
                string dateText = journalEntry.obtainDateTextNow();// METHOD - JournalEntry
                
                //Console.WriteLine($"Date: {dateText} - Promt: {promt} ");
                //Console.WriteLine($"{answer}");


                //Create the file with append option
                journalEntry.regestryJournal(newfilename,dateText,promt,answer);// METHOD - JournalEntry
                
                
                //Console.WriteLine("//Write");


            }
            else if (option == 2) //Display
            {
                //Console.WriteLine("Display");

                journal.readJournal(newfilename); // METHOD - Journal
                

                //Console.WriteLine("//Display");
            }
            else if (option == 3) //Load
            {
                newfilename = journal.loadJournal(); // METHOD - Journal

            }
               else if (option == 4) //Save
            {
                Console.WriteLine("Save");

                journal.saveJournal(newfilename,defaultfilename); // METHOD - Journal

            }
               else if (option == 5) //Quit
            {
                Console.WriteLine("Quit");
                
                // create the new file to clean it
                using (StreamWriter outputFile = new StreamWriter(defaultfilename))
                {
                }
                Console.WriteLine("Bye Bye");
            }
            Console.WriteLine("");
        } 



    }


}
/*
journal 
journal entry

Este programa debe contener las siguientes caracter??sticas:

1 - Escribir una nueva entrada: 
    muestra al usuario un mensaje aleatorio (de una lista que crees) y 
        guarda su respuesta, el mensaje y la fecha como una entrada.
2 - Mostrar el diario: recorra en iteraci??n todas las entradas del diario y mu??strelas en la pantalla.
Guardar el diario en un archivo: solicite al usuario un nombre de archivo y, a continuaci??n, guarde el diario actual (la lista completa de entradas) en esa ubicaci??n de archivo.
3 - Cargar el diario desde un archivo: solicite al usuario un nombre de archivo y, a continuaci??n, cargue el diario (una lista completa de entradas) desde ese archivo. Esto deber??a reemplazar cualquier entrada almacenada actualmente en el diario.
4 - Proporcionar un men?? que permita al usuario elegir estas opciones
La lista de mensajes debe contener al menos cinco mensajes diferentes. Aseg??rese de agregar sus propios mensajes a la lista, pero los siguientes son ejemplos para ayudarlo a comenzar:
??Qui??n fue la persona m??s interesante con la que interactu?? hoy?
??Cu??l fue la mejor parte de mi d??a?
??C??mo vi la mano del Se??or en mi vida hoy?
??Cu??l fue la emoci??n m??s fuerte que sent?? hoy?
Si tuviera una cosa que pudiera hacer hoy, ??cu??l ser??a?
Su interfaz generalmente debe seguir el patr??n que se muestra en la demostraci??n de video a continuaci??n.
*/