using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");



        // Una vez que tenga las clases en su lugar, escriba un programa que cree al menos un evento de cada tipo y establezca todos sus valores. 
        // Luego, para el evento de evento, llame a cada uno de los métodos para generar los mensajes de marketing y enviar sus resultados a la pantalla.

        // Además, su programa debe:

        // Utilice la herencia para evitar la duplicación de atributos y métodos compartidos.
        // Utilice una clase de dirección para las direcciones.
        // Siga los principios de encapsulación, asegurándose de que cada variable miembro sea privada


        //Crear evento Lecture Reception OutdoorGathering
        Address address = new Address ("Lisandro", "Orem", "Utah", "2323", "USA" );
        Lecture lecture = new Lecture("Conferencia de Presna Boca Juniors", "Conferencia posterior al partido de BOCA JR", "12 Dic 2024", "21:00", address,1,"Roberto", "30");
        Reception reception = new Reception ("Cumpleanos sorpresa", "Se realizara un cumplea;os sorpresa para Evangelina Garcia", "7 Oct 2024", "20:00", address,2,"keyla@gmail.com","Keyla");
        OutdoorGathering outdoor = new OutdoorGathering ("Fiesta 40 Aniversario", "Se festejara el 30 aniversario de Diego y Cynthia", "5 Jul 2025", "12:00", address,3,"Nublado");

        Console.WriteLine ("--- Lecture ---");
        Console.WriteLine("Short Description: "+lecture.shortDescription());
        Console.WriteLine ();
        Console.WriteLine("Standard Message: "+lecture.standarMessage());
        Console.WriteLine ();
        Console.WriteLine("Full Detail Message: "+ lecture.fullDetailedMessage());

        Console.WriteLine ();
        Console.WriteLine ("--- Reception ---");
        Console.WriteLine("Short Description: "+reception.shortDescription());
        Console.WriteLine ();
        Console.WriteLine("Standard Message: "+reception.standarMessage());
        Console.WriteLine ();
        Console.WriteLine("Full Detail Message: "+ reception.fullDetailedMessage());


        Console.WriteLine ();
        Console.WriteLine ("--- Outdoor Gathering ---");
        Console.WriteLine("Short Description: "+outdoor.shortDescription());
        Console.WriteLine ();
        Console.WriteLine("Standard Message: "+outdoor.standarMessage());
        Console.WriteLine ();
        Console.WriteLine("Full Detail Message: "+ outdoor.fullDetailedMessage());

        Console.WriteLine ();
    }
}