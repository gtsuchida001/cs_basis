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
            /*for (int num = 3; num >= 0; num--)
            {
                if (num != 0)
                    Console.WriteLine("num={0}" , num);
                else
                    Console.Write("num=0");
            }*/
            int num = 3;
            while (num >= 0)
            {
                if (num != 0)
                    Console.WriteLine("num={0}", num);
                else
                    Console.Write("num=0");
                num--;
            }
        }
    }
}