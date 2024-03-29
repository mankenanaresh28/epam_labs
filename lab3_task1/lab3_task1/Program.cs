using System;

public class Rectangle
{
    private double sideA;
    private double sideB;

    public Rectangle(double a, double b)
    {
        sideA = a;
        sideB = b;
    }

    public Rectangle(double a) : this(a, 5)
    {
    }

    public Rectangle() : this(4, 3)
    {
    }

    public double GetSideA()
    {
        return sideA;
    }

    public double GetSideB()
    {
        return sideB;
    }

    public double Area()
    {
        return sideA * sideB;
    }

    public double Perimeter()
    {
        return 2 * (sideA + sideB);
    }

    public bool IsSquare()
    {
        return sideA == sideB;
    }

    public void ReplaceSides()
    {
        double temp = sideA;
        sideA = sideB;
        sideB = temp;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle(6, 8);
        Console.WriteLine("Side A: " + rect1.GetSideA());
        Console.WriteLine("Side B: " + rect1.GetSideB());
        Console.WriteLine("Area: " + rect1.Area());
        Console.WriteLine("Perimeter: " + rect1.Perimeter());
        Console.WriteLine("Is Square: " + rect1.IsSquare());

        Rectangle rect2 = new Rectangle(5);
        Console.WriteLine("\nSide A: " + rect2.GetSideA());
        Console.WriteLine("Side B: " + rect2.GetSideB());
        Console.WriteLine("Area: " + rect2.Area());
        Console.WriteLine("Perimeter: " + rect2.Perimeter());
        Console.WriteLine("Is Square: " + rect2.IsSquare());

        Rectangle rect3 = new Rectangle();
        Console.WriteLine("\nSide A: " + rect3.GetSideA());
        Console.WriteLine("Side B: " + rect3.GetSideB());
        Console.WriteLine("Area: " + rect3.Area());
        Console.WriteLine("Perimeter: " + rect3.Perimeter());
        Console.WriteLine("Is Square: " + rect3.IsSquare());

        rect3.ReplaceSides();
        Console.WriteLine("\nAfter swapping sides:");
        Console.WriteLine("Side A: " + rect3.GetSideA());
        Console.WriteLine("Side B: " + rect3.GetSideB());
    }
}
