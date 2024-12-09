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
            for (int a = 0; a < 10; a++)
            {
                int index = 0;
                while (index < 10)
                {
                    if (index == a)
                        Console.Write("□");
                    else
                        Console.Write("■");
                    index++;
                }
                if (a != 10)
                    Console.WriteLine();
            }
        }
    }
}