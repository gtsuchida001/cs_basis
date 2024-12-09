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
            Console.Write("abcと入力してください：");
            string? inputString = Console.ReadLine();
            if (inputString == "abc")
            {
                Console.WriteLine("abcです。");
            }
            else
            {
                Console.WriteLine("abcではありません。");
            }
        }
    }
}