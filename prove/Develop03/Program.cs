using System;

class Program
{
    static void Main(string[] args)
    {

        string book = "John"; 
        int chapter = 3;
        int startVers =16;
        string texto = "For God so loved the world, that he gave his eonly begotten Son, that whosoever believeth in him should not perish, but have everlasting life.; For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        int endVers =17;
    
        
        //Reference referencia = new Reference(book,chapter,startVers);
        Reference referencia = new Reference(book,chapter,startVers,endVers);

        Scripture escritura = new Scripture(referencia, texto);

        escritura.displayScripture();
        string quit = "";
        Console.WriteLine("\n\nPress Enter to continue or type 'quit' to end the program"  );
        quit = Console.ReadLine();

        while (quit != "quit")
        {
            Console.Clear();
            escritura.hideWorlds();
            escritura.displayScripture();
           
            
            if (quit != "quit" && escritura.getCantPalabras() == escritura.getCantPalabrasEscondidas()){
                Console.WriteLine("\n\nThe program will finish, thank you :) "  );
                quit = "quit";
            }else{
                Console.WriteLine("\n\nPress enter to continue or type 'quit' to end the program"  );
                quit = Console.ReadLine();
            }
        }


        // String parrafo = "Hello Develop03 World!";
        // string[] parrafoPorPalabras = parrafo.Split(' ');
        // Console.WriteLine(parrafo);
        // int i =0;
        // int j = parrafoPorPalabras.Count();
        
        // //recorrer parrafo (arreglo de string) por palabra (string)
        //     foreach (string p in parrafoPorPalabras)
        //         {
        //             Console.Write(p + ' ');
        //             i = i+1;
        //         }
        //         Console.Write($"\n Palabras: {i} - {j}");
        // string palabra = "Hello";
        // Console.WriteLine(palabra);

        // Word word = new Word(palabra);
        // Console.WriteLine(word.getWord());
        // Console.WriteLine(word.getHideord());


    }

 

}