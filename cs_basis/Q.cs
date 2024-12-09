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
            Console.Write("整数を入力してください(1-100)：");
            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out int result) || inputString == null)
                return ;
            int input = int.Parse(inputString);

            int index = input % 2;
            if (input <= 100 && input >= 1)
            {
                if (input <= 50)
                {
                    if (index == 0)
                        Console.WriteLine("50以下の偶数です。");
                    else
                        Console.WriteLine("50以下です。");
                    return ;
                }
                if (index == 0)
                    Console.WriteLine("偶数です。");
                return ;
            }
            else
                Console.WriteLine("適切な値を入力してください。");
            return ;
        }
    }
}