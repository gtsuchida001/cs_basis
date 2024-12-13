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
            Random random = new Random();
            int y = random.Next(1, 11);
            int x = random.Next(1, 11);
            int y2 = random.Next(1, 11);
            int x2 = random.Next(1, 11);
            int y3 = 0;
            int x3 = 0;

            x3 = x * x2;
            y3 = y2 * x + y * x2;

            for (int i = 2; i <= Math.Min(x3, y3); i++)
            {
                if (x3 % i == 0 && y3 % i == 0)
                {
                    x3 /= i;
                    y3 /= i;
                    i = 1;
                }
            }
            Console.Write("{0}/{1} + {2}/{3} = {4}/{5} " ,y,x,y2,x2,y3,x3);
        }
    }
}