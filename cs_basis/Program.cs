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
            int i = random.Next(1, 1001);
            int j = 0;

            Console.WriteLine("The number is: " + i);
            for (int k = 1; k < i + 1; k++)
            {
                if (i % k == 0)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}