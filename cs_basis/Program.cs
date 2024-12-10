using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basis
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;

            for (int a = 1; a <= max; a++)
            {
                for (int b = a; b <= max; b++)
                {
                    double c = Math.Sqrt(a * a + b * b);
                    if (c % 1 == 0 && c <= max)
                    {
                        Console.WriteLine(a + " " + b + " " + c);
                    }
                }
            }
        }
    }
}