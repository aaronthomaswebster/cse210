using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());
        Console.WriteLine(f1.GetFractionString());

        Fraction f2 = new Fraction(2);
        Console.WriteLine(f2.GetTop());
        Console.WriteLine(f2.GetBottom());
        Console.WriteLine(f2.GetFractionString());

        Fraction f3 = new Fraction(9,3);
        Console.WriteLine(f3.GetTop());
        Console.WriteLine(f3.GetBottom());
        Console.WriteLine(f3.GetFractionString());

        f3.SetBottom(12);
        f3.SetTop(4);

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());


    }
}