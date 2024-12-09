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
            Random rnd = new Random();
            int n = rnd.Next(1, 11);
            Console.WriteLine("発生した数値：" + n);
            if (n % 2 == 0)
                for (int i = 0; i < n; i++)
                    Console.Write("★");
            else
            {
                for (int i = 0; i < n; i++)
                    Console.Write("☆");
            }
        }
    }
}