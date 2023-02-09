public class Fraction 
{

    private int _top;
    private int _bottom;


    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }
    
    public Fraction(int numerador, int denominador){
        _top = numerador;
        _bottom = denominador;
    }

    public int getTop (){
        return _top;
    }
    public void setTop (int top){
        _top = top;
    }
    public int getBottom (){
        return _bottom;
    }
    public void setBottom (int bottom){
        _bottom = bottom;
    }

    public string GetFractionString (){
        return _top.ToString() + "/" + _bottom.ToString();
    }

    public double GetDecimalValuedouble (){
        return (double)_top/_bottom;
    }
}