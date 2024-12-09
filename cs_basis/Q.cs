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
            Console.Write("整数値を入力：");
            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out int result) || inputString == null)
                return ;
            int input = int.Parse(inputString);
            
            int p2 = input % 2;
            int p3 = input % 3;
            if (p2 == 0 && p3 == 0)
            {
                Console.WriteLine("2と3の公倍数です。");
                return;
            }
            else if (p2 == 0)
            {
                Console.WriteLine("2の公倍数です。");
                return;
            }
            else if (p3 == 0)
            {
                Console.WriteLine("3の公倍数です。");
                return;
            }
            else
                Console.WriteLine("2でも3でも割り切れません");
        }
    }
}