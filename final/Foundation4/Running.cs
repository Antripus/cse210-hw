public class Running : Activity
{

    private float _distance;

    public Running(string date, float length, float distance) : base(date, length)
    {
        _distance = distance;
        _type = "Running";
    }

    protected override float getDistance()
    {
        //Distance (km) = swimming laps * 50 / 1000

        return _distance;
    }

    // Distance (km) = swimming laps * 50 / 1000
    // Speed (mph or kph) = (distance / minutes) * 60
    // Pace (min per mile or min per km)= minutes / distance
    // Speed = 60 / pace
    // Pace = 60 / speed
    protected override float getPace()
    {
        return getLength() / _distance;
    }

    protected override float getSpeed()
    {
        return 60 / getPace();
    }
}