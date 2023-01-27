using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        string defaultfilename = "myFile.txt";
        string newfilename=defaultfilename;
        int option = 0;
        List<string> promts = new List<string>();
        promts.Add("What was the best part of my day?");
        promts.Add("What was I learn today?");
        promts.Add("Who take my attention today?");
        promts.Add("Something surprise me today?");
        promts.Add("How I see the hand of the lord today?");



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
                Console.WriteLine("Write");
                
                // Take a random index number from promts and then print in the console
                var random = new Random(); 
                int index = random.Next(promts.Count);
                string promt = promts[index];
                Console.WriteLine(promt);

                Console.Write("> ");
                string answer = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                
                //Console.WriteLine($"Date: {dateText} - Promt: {promt} ");
                //Console.WriteLine($"{answer}");


                //Create the file with append option
                using (StreamWriter outputFile = new StreamWriter(newfilename, append: true))
                {
                    outputFile.WriteLine($"Date: {dateText} - Promt: {promt} ");
                    outputFile.WriteLine($"{answer}");
                }

                Console.WriteLine("//Write");


            }
            else if (option == 2) //Display
            {
                Console.WriteLine("Display");

                string[] lines = System.IO.File.ReadAllLines(newfilename);

                foreach (string line in lines)
                {
                    Console.WriteLine($"{line}");
                }
                Console.WriteLine("//Display");
            }
            else if (option == 3) //Load
            {
                Console.WriteLine("Load");
                Console.WriteLine("What is the file name?");
                
                Console.Write("> ");
                newfilename = Console.ReadLine();
            }
               else if (option == 4) //Save
            {
                Console.WriteLine("Save");

                Console.WriteLine("What is the file name?");
                
                Console.Write("> ");
                string newfilename2 = Console.ReadLine();
                using (var reader = new StreamReader(newfilename))
                using (var writer = new StreamWriter(defaultfilename, append: false))
                {
                    writer.Write(reader.ReadToEnd());
                }
                // I need to do 2 copies because when I try to copy a file with the same name give me an error. So I create a bridge with my default name file
                using (var reader = new StreamReader(defaultfilename))
                using (var writer = new StreamWriter(newfilename2, append: false))
                {
                    writer.Write(reader.ReadToEnd());
                }

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
Este programa debe contener las siguientes características:

1 - Escribir una nueva entrada: 
    muestra al usuario un mensaje aleatorio (de una lista que crees) y 
        guarda su respuesta, el mensaje y la fecha como una entrada.
2 - Mostrar el diario: recorra en iteración todas las entradas del diario y muéstrelas en la pantalla.
Guardar el diario en un archivo: solicite al usuario un nombre de archivo y, a continuación, guarde el diario actual (la lista completa de entradas) en esa ubicación de archivo.
3 - Cargar el diario desde un archivo: solicite al usuario un nombre de archivo y, a continuación, cargue el diario (una lista completa de entradas) desde ese archivo. Esto debería reemplazar cualquier entrada almacenada actualmente en el diario.
4 - Proporcionar un menú que permita al usuario elegir estas opciones
La lista de mensajes debe contener al menos cinco mensajes diferentes. Asegúrese de agregar sus propios mensajes a la lista, pero los siguientes son ejemplos para ayudarlo a comenzar:
¿Quién fue la persona más interesante con la que interactué hoy?
¿Cuál fue la mejor parte de mi día?
¿Cómo vi la mano del Señor en mi vida hoy?
¿Cuál fue la emoción más fuerte que sentí hoy?
Si tuviera una cosa que pudiera hacer hoy, ¿cuál sería?
Su interfaz generalmente debe seguir el patrón que se muestra en la demostración de video a continuación.
*/