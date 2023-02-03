

public abstract class Shape{


    public string _color = "";

    public Shape(string color)
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