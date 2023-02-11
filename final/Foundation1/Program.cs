using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Youtube Video & Comments");

        int cantVideos = 4;

        List<Video> videos = new List<Video> ();

        Random rnd = new Random();
        string[] comentarios = {"El video esta super", "no me gusto el principio", "Es demasiado largo", "Como hiciste un video tan bueno, me encanta", "Aceptable, me gusta"};
        string[] nombres = {"Jhon", "Debra", "AxelCAPO", "BOCACAMPEON22", "Blake Smith", "Javito", "Keylucha", "laliebre"};

        int x = 0;
        while (cantVideos > 0){
            x = x+1;
            int rndIndexNombres = rnd.Next(nombres.Length);
            int rndSeconds = rnd.Next(1,180);
            //Creo el video con  nombre y segundos random
            Video newVideo =  new Video($"Vid-{x}", nombres[rndIndexNombres], rndSeconds);
            //Agrego el video a mi lista de videos
            videos.Add (newVideo);
            cantVideos = cantVideos -1;
        }

        //recorro la lista para agregar comentarios
        foreach (Video v in videos){
            int cantComentarios = rnd.Next(1,5);
            //Agrego la cantidad de comentarios random a este video
            while (cantComentarios>0)
            {
                //genero index randoms para comentarios y nombres 
                int rndIndexComentarios = rnd.Next(comentarios.Length);
                int rndIndexNombres = rnd.Next(nombres.Length);
                //agrego el comentario con el nombre  y el comentario
                v.addComment(nombres[rndIndexNombres],comentarios[rndIndexComentarios]);
                cantComentarios = cantComentarios -1;
            }
            
        }

        //recorro la lista de videos para mostrar lo solicitado
        foreach (Video v in videos){
            string author = v.getAuthor();
            string title = v.getTitle();
            int tiempoSegundos = v.getSeconds();
            int numeroDeComentarios = v.getNumberOfComments();
            
            Console.WriteLine();
            Console.WriteLine($"Title: {title} - Author: {author} - Time in seconds: {tiempoSegundos}");
            Console.WriteLine($"Number of comments: {numeroDeComentarios}");
            v.displayComments();
        }
    }



}