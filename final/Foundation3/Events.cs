public abstract class Events 
{


    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private int _type;

    protected Events(string title, string description, string date, string time, Address address, int type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string standarMessage () //Detalles estándar: enumera el título, la descripción, la fecha, la hora y la dirección.
    {
        //string respuesta= _title + " - " + _description + " - " + _date + " - " +_time  + " - " + _address.ToString();
        string message= $"Title: {_title} Description: {_description} \nDate: {_date} Time: {_time} \nAddress: {_address.ToString()}";
        return message;
       
    }

    public string shortDescription() //Short description - Lists the type of event, title, and the date.
    {
        string answer = "There is not Events";
        switch (_type){
            case 1:  //Lecture
                answer= $"Event Type: Lecture, Title: {_title}, Date: {_date}";
            break;
            case 2: //Receptions
                answer= $"Event Type: Receptions, Title: {_title}, Date: {_date}";
            break;
            case 3: //Outdoor gatherings
                answer= $"Event Type: Outdoor gatherings, Title: {_title}, Date: {_date}";
            break;
        }
        return answer;  
    }


    public abstract string fullDetailedMessage(); 
    // Detalles completos: enumera todo lo anterior, además del tipo de evento y la información específica de ese tipo de evento. 
    // Para las conferencias, esto incluye el nombre del orador y la capacidad. Para las recepciones, esto incluye un correo 
    // electrónico para confirmar su asistencia. Para reuniones al aire libre, esto incluye una declaración del clima.

    // public void setType(int type){
    //     _type = type;
    // }



}