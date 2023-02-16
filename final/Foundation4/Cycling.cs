public class Cycling : Activity
{

    private float _speed;
    // private string _type = "Cycling";
    

    public Cycling(string date, float length, float speed) : base(date, length)
    {
        _speed = speed;
        _type = "Cycling";
    }

    protected override float getSpeed()
    {
        return _speed;
    }
    // Distance (km) = swimming laps * 50 / 1000
    // Speed (mph or kph) = (distance / minutes) * 60
    // Pace (min per mile or min per km)= minutes / distance
    // Speed = 60 / pace
    // Pace = 60 / speed

    protected override float getDistance()
    {
        return getPace()/getLength();
    }

    protected override float getPace()
    {
        return 60/_speed;
    }

    
}