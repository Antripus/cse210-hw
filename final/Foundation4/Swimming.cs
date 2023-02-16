public class Swimming : Activity{


    private float _numberLaps;

    public Swimming(string date, float length, float numberLaps) : base(date, length)
    {
        _numberLaps = numberLaps;
        _type = "Swimming";
        // Distance (km) * 1000 / 50 = swimming laps 
    }

    // Distance (km) = swimming laps * 50 / 1000
    // Speed (mph or kph) = (distance / minutes) * 60
    // Pace (min per mile or min per km)= minutes / distance
    // Speed = 60 / pace
    // Pace = 60 / speed
    public float getNumberLaps()
    {
        return _numberLaps;
    }

    protected override float getDistance()
    {
        return _numberLaps *50 /1000;
    } 

    protected override float getSpeed()
    {
        return 60 / getPace();
    }
    
    protected override float getPace()
    {
        return getLength() / getDistance();
    }
}