using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            if (input != null && input2 != null)
                Console.Write(input + input2);
        }
    }
}