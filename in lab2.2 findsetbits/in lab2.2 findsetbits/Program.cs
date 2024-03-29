using System;
namespace countsetbits;
class CountSetbits
{
    public static void Main(string[] args)
    {
        int a=Convert.ToInt32(Console.ReadLine());
        int c = 0;
        while(a>0)
        {   
            int res=a&1;
            if (res == 1)
            {
                c = c + 1;
            }
            a=a>>1;
        }
    Console.WriteLine(c);
    }
}
