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
            Console.Write("数字を入力：");
            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out int result) || inputString == null)
                return ;
            int input = int.Parse(inputString);
            if (input == 0)
                Console.WriteLine("入力された数字は0です。");
            else if (input > 0)
                Console.WriteLine("入力された数字は正の数です。");
            else
                Console.WriteLine("入力された数字は負の数です。");
        }
    }
}