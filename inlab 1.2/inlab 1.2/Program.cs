using System;
namespace Find;
class Find
{
    public static void Main(string[] args)
    {
        int a=Convert.ToInt32(Console.ReadLine());
        if (a>0)
            {
            Console.WriteLine("square=" + (Math.Pow(a, 2)));
        }
        else if (a<0) 
        {
            Console.WriteLine("modulus =" + (Math.Abs(a)));
        }
        else
        { Console.WriteLine("0"); }
    }
}