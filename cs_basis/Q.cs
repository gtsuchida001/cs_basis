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
            int max = 0;
            int min = 100;
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                int n = rnd.Next(1, 100);
                Console.WriteLine(n);
                if (max < n)
                    max = n;
                if (min > n)
                    min = n;
            }
            Console.WriteLine("最大値: " + max);
            Console.Write("最小値: " + min);
        }
    }
}