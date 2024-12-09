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
            int even = 0;
            int odd = 0;
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                int n = rnd.Next(1, 100);
                Console.WriteLine(n);
                if (n % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine("偶数の数：" + even);
            Console.Write("奇数の数：" + odd);
        }
    }
}