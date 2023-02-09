using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3,4);
        Fraction frac4 = new Fraction(1,3);

        // LLamada a las 2 funciones creadas GetFractionString y GetDecimalValuedouble
        Console.WriteLine(frac1.GetFractionString() + " = " + frac1.GetDecimalValuedouble().ToString());
        Console.WriteLine(frac2.GetFractionString() + " = " + frac2.GetDecimalValuedouble().ToString()); 
        Console.WriteLine(frac3.GetFractionString() + " = " + frac3.GetDecimalValuedouble().ToString());
        Console.WriteLine(frac4.GetFractionString() + " = " + frac4.GetDecimalValuedouble().ToString());

    }
}