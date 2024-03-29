using System;

class Program
{
    static double MultArithmeticElements(double a1, double t, int n)
    {
        double multiplication = 1;
        double currentElement = a1;

        for (int i = 0; i < n; i++)
        {
            multiplication *= currentElement;
            currentElement += t;
        }

        return multiplication;
    }

    static void Main(string[] args)
    {
        double a1 = 5;
        double t = 3;
        int n = 4;

        double result = MultArithmeticElements(a1, t, n);
        Console.WriteLine("Multiplication: " + result);
    }
}
