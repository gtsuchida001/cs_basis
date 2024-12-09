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
            string inputString = Console.ReadLine();
            int input = int.Parse(inputString);
            if (input >= 0 && input <= 100)
            {
                    if (input >= 20 && input <= 80)
                Console.WriteLine("20以上80未満です。");
                    else
                    Console.WriteLine("20未満か80以上です。");
            }
            else
            {
                Console.WriteLine("範囲外です");
            }
        }
    }
}