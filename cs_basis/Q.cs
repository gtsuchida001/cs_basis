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
            int []a = new int[7];
            for (int index = 0; index < a.Length; index++)
            {
                Random random = new Random();
                a[index] = random.Next(1, 11);
                Console.Write("a[{0}] = {1}  ", index, a[index]);
            }
        }
    }
}