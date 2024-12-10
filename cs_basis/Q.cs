using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basis
{
    class Program
    {
        static void Main()
        {
            int []data = new int[7];

            for (int index = 0; index < data.Length; index++)
            {
                Random random = new Random();
                data[index] = random.Next(0, 11);
                Console.Write("{0}", data[index]);
                if (data[index] != data[^1])
                    Console.Write(" ");
            }
            Console.WriteLine("\n");
            for (int index = 0; index < data.Length; index++)
            {
                int i = data[index];
                if (i == 0)
                    Console.WriteLine();
                while (i > 0)
                {
                    Console.Write("*");
                    if (i == 1)
                        Console.WriteLine();
                    i--;
                }
            }
            
            int t = Console.Read();
        }
    }
}