public class Reception : Events
{
    private string _RSVP; //email
    private string _register;
    


    public Reception(string title, string description, string date, string time, Address address, int type, string rsvp, string register) : base(title, description, date, time, address, type)
    {
        _RSVP = rsvp;
        _register = register;
    }//type = 2


    public override string fullDetailedMessage()
    {
        string respuesta = standarMessage() + $"\nEvent Type: Reception - Email for RSVP: {_RSVP} - Register: {_register}";
        return respuesta;
    } 
}