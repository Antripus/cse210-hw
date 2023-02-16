public class Lecture : Events
{

    private string _speaker;
    private string _limitedCapacity;

    public Lecture(string title, string description, string date, string time, Address address, int type, string speaker, string limitedCapacity) : base (title, description, date, time, address, type)
    {
        _speaker = speaker;
        _limitedCapacity = limitedCapacity;
    }//type = 1

    public override string fullDetailedMessage()
    // Detalles completos: enumera todo lo anterior, además del tipo de evento y la información específica de ese tipo de evento. 
    // Para las conferencias, esto incluye el nombre del orador y la capacidad. Para las recepciones, esto incluye un correo 
    // electrónico para confirmar su asistencia. Para reuniones al aire libre, esto incluye una declaración del clima.
    {
        string respuesta = standarMessage() + $"\nEvent Type: Lecture - Speaker Name: {_speaker} - Capacity: {_limitedCapacity}";
        return respuesta;
    }
}