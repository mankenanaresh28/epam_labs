using System;

public static class MathExtensions
{
    // Extension method to calculate the sum of digits of an integer
    public static int SumDigits(this int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    // Extension method to reverse an integer
    public static int Reverse(this int number)
    {
        int reverse = 0;
        while (number != 0)
        {
            reverse = reverse * 10 + number % 10;
            number /= 10;
        }
        return reverse;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int number = 1234;
        int sumOfDigits = number.SumDigits(); // 1 + 2 + 3 + 4 = 10
        int reversedNumber = number.Reverse(); // 4321

        Console.WriteLine($"Sum of digits of {number}: {sumOfDigits}");
        Console.WriteLine($"Reverse of {number}: {reversedNumber}");
    }
}
