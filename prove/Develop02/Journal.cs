

public class Journal
{
   
        // The C# convention is to start member variables with an underscore _
        


        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Journal()
        {
        }


        //Save Journal
        public static void saveJournal (string newfilename, string defaultfilename) {
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
        //Load Journal
        public static string loadJournal () {
            Console.WriteLine("Load");
            Console.WriteLine("What is the file name?");
            Console.Write("> ");
            string newfilename = Console.ReadLine();
            
            return newfilename;
        }
        //Read Journal
        public static void readJournal (string newfilename) {

            string[] lines = System.IO.File.ReadAllLines(newfilename);

            foreach (string line in lines)
            {
                Console.WriteLine($"{line}");
            }
        }

        //tests
        public static void grabarLibro(){
            Console.WriteLine ("HOLA");
        }

        static void grabarLibro2(){
            Console.WriteLine ("HOLA");
        }
        //test

}