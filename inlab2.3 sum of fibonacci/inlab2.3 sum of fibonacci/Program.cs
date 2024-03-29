using System;
namespace FibonacciSum;
class FibonacciSum
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int f0 = 0, f1 = 1,s = f1+f0,f2=0;
        for(int i=2;i<a;i++)
        {
            f2 = f0 + f1;
            s = f2 + s;
            f0 = f1;
            f1 = f2;
        }
        Console.WriteLine(s);


    }
}
