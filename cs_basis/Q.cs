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
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                return;
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (number == 3)
                Console.Write(number);
        }
    }
}