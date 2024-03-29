using System;
namespace simplecalculator;
class simpleCalculator
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1.add\n2.substraction\n3.Multiplication\n4.division\n5.squareRoot");
        Console.WriteLine("Enter Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine()); 
        
        
        switch (choice)
            {
               case 1:
                   Console.WriteLine($"sum of two numbers is  { a + b}");
                   break;
                case 2:
                
                   Console.WriteLine($"Difference of two numbers is { Math.Abs(a - b)}");
                   break;
                case 3:
                    Console.WriteLine($"Multiplication of two numbers is  { a* b}");
                    break; 
                case 4:
                    int res;
                    if (a>b)
                    {
                         res=a/b;
                    }
                    else
                    {
                        res=b/a;
                    }
                    Console.WriteLine($"Division of two numbers is  { res}");
                    break;
                case 5:
                    Console.WriteLine($"squareRoot of a is { Math.Sqrt(a)}");
                    break;  




            }
        


    }
}