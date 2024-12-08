using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine("a={0} b={1}\naはbよりも大きい", a, b);
            else if (a < b)
                Console.WriteLine("a={0} b={1}\naはbよりも小さい", b, a);
            else
                Console.WriteLine("a=b={0}\naはbと等しい" , a);
        }
    }
}