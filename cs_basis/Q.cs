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
            for (int i = 0; i < 5; i++)
            {
                Random r = new Random();
                int n = r.Next(1, 101);
                Console.Write(n);
                if (i != 4)
                    Console.Write("\n");
            }
        }
    }
}