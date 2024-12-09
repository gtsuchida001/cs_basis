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
            int index = 0;
            while (index >= 0)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 100);
                Console.Write(number);
                if (number % 10 == 0)
                    index--;
                else
                    Console.Write("\n");
            }
        }
    }
}