

public abstract class shape{


    public string _color = "";

    public shape(string color)
    {
        _color = color;
    }


    public string getColor ()
    {
        return _color;
    }
    public void setColor (string color)
    {
        _color = color;
    }

    public abstract double getArea();

}