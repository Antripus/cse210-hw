public class OutdoorGathering : Events
{

    private string _weatherForecast;


    public OutdoorGathering(string title, string description, string date, string time, Address address, int type, string weatherForecast) : base(title, description, date, time, address, type)
    {
        _weatherForecast = weatherForecast;

    }//type=3

    public override string fullDetailedMessage()
    {
        string respuesta = standarMessage() + $"\nEvent Type: Outdoor Gathering - Weather Forecast: {_weatherForecast}";
        return respuesta;
    }

}