using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    Console.Write("{0}*{1}={2}  ", a, b, a*b);
                    if (b == 9 && a != 9)
                        Console.WriteLine("");
                }
            }
        }
    }
}