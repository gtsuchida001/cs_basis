using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数字を入力：");
            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out int result) || inputString == null)
                return;
            int input = int.Parse(inputString);
            if (input % 2 == 0)
            {
                Console.WriteLine("この数は偶数です。");
            }
            else
            {
                Console.WriteLine("この数は奇数です。");
            }
        }
    }
}