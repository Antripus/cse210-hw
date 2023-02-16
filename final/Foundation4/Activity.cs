public abstract class Activity
{

    private string _date;
    private float _length; //duracion en minutos
    protected string _type;

    // private float _distance;
    // private float _speed;
    // private float _pace;

    public Activity ()
    {

    }

    public Activity(string date, float length)//, float distance, float speed, float pace)
    {
        _date = date;
        _length = length;
        
        // _distance = distance;
        // _speed = speed;
        // _pace = pace;
    }

    protected virtual float getDistance()
    {
        return 0;
    }
    
    protected virtual float getSpeed()
    {
        return 0;
    }
    
    protected virtual float getPace()
    {
        return 0;
    }

    public string getSummary() //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
    {
        string summary = $"{_date} {_type} ({_length} min): Distance {getDistance().ToString("0.##")} km, Speed: {getSpeed().ToString("0.##")} kph, Pace: {getPace().ToString("0.##")} min per km";
        return summary;
    }

    // In addition, the base class should contain virtual methods for getting the distance, speed, pace. 
    // These methods should be overridden in the derived classes.

    public float getLength()
    {
        return _length;
    }

    public string getDate()
    {
        return _date;
    }
    public string getType()
    {
        return _type;
    }


}