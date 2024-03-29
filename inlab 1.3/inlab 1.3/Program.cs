using System;
namespace Find;
class Find
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a three digit number:");
        String g = Console.ReadLine();
        if (g.Length == 3 && int.TryParse(g, out int n))
        {
            int[] digits = g.Select(c => int.Parse(c.ToString())).ToArray();
            Array.Sort(digits);
            Array.Reverse(digits);
            int result = int.Parse(string.Join("", digits));

            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid three-digit number.");
        }
    }
}