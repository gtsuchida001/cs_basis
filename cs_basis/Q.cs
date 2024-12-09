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
            Console.Write("温度を入力してください(-10～35)：");
            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out int result) || inputString == null)
            {
                Console.WriteLine("適切な値を入力してください。");
                return;
            }
            int input = int.Parse(inputString);
            Console.Write("摂氏{0}度", input);
            if (input >= 30)
                Console.Write("\n真夏日です");
            else if (input >= 25　&& input <30)
                Console.Write("\n夏日です");
            else if (input < 0)
                Console.Write("\n真冬日です");
        }
    }
}