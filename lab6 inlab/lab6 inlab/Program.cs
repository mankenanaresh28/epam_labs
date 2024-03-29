using System;
using System.Collections.Generic;
using System.Linq;

public static class MyExtension
{
    // Extension method to calculate the sum of digits of an integer
    public static int SummaDigit(this int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    // Extension method to calculate the sum of the original positive integer 
    // with the number obtained from the original by rearranging all digits in reverse order
    public static uint SummaWithReverse(this uint number)
    {
        uint reversedNumber = ReverseDigits(number);
        return number + reversedNumber;
    }

    private static uint ReverseDigits(uint number)
    {
        uint reverse = 0;
        while (number > 0)
        {
            reverse = reverse * 10 + number % 10;
            number /= 10;
        }
        return reverse;
    }

    // Extension method to count non-Latin letter characters in a string
    public static int CountNotLetter(this string str)
    {
        return str.Count(c => !char.IsLetter(c) && !char.IsWhiteSpace(c));
    }

    // Extension method to check if a day is a weekend
    public static bool IsDayOff(this DayOfWeek day)
    {
        return day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
    }

    // Extension method to filter even positive elements from a sequence of integers
    public static IEnumerable<int> EvenPositiveElements(this IEnumerable<int> numbers)
    {
        return numbers.Where(n => n > 0 && n % 2 == 0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Console.WriteLine("Example 1: SummaDigit");
        int n1 = 1274;
        Console.WriteLine($"Sum of digits of {n1}: {n1.SummaDigit()}");

        Console.WriteLine("\nExample 2: SummaWithReverse");
        uint n2 = 132;
        Console.WriteLine($"Sum of {n2} and its reverse: {n2.SummaWithReverse()}");

        Console.WriteLine("\nExample 3: CountNotLetter");
        string s = "I like С#";
        Console.WriteLine($"Number of non-letter characters in '{s}': {s.CountNotLetter()}");

        Console.WriteLine("\nExample 4: IsDayOff");
        DayOfWeek day = DayOfWeek.Sunday;
        Console.WriteLine($"{day} is a day off: {day.IsDayOff()}");

        Console.WriteLine("\nExample 5: EvenPositiveElements");
        int[] mas = { 2, -2, 3, 4, 0, 6, 1, 9 };
        Console.WriteLine($"Even positive elements in array: {string.Join(", ", mas.EvenPositiveElements())}");

        Console.WriteLine("\nExample 6: EvenPositiveElements with List<int>");
        List<int> list = new List<int> { 2, 3, -4, 8, 5, 4 };
        Console.WriteLine($"Even positive elements in list: {string.Join(", ", list.EvenPositiveElements())}");
    }
}

