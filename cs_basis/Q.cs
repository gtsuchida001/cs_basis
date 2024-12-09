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
            /*Console.Write("整数値を入力：");
            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out int result) || inputString == null)
            {
                Console.WriteLine("適切な値を入力してください。");
                return;
            }
            int input = int.Parse(inputString);
            int i = 0;
            do
            {
                Console.Write("■");
                i++;
            } while (i < input);*/
            for (int a = 2; a <= 8; a += 2)
            {
                if (a != 8)
                    Console.WriteLine("a={0}", a);
                else
                    Console.Write("a=8");
            }
            /*int a = 2;
            while (a <= 8)
            {
                if (a != 8)
                    Console.WriteLine("a={0}", a);
                else
                    Console.Write("a=8");
                a += 2;
            }*/
        }
    }
}