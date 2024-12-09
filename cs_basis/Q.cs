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
            Console.Write("点数(1-100)：");
            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out int result) || inputString == null)
                return;
            int input = int.Parse(inputString);
            if (input >= 80 && input <=100)
                Console.WriteLine("優");
            else if (input >= 70 && input < 80)
                Console.WriteLine("良");
            else if (input >= 60 && input < 70)
                Console.WriteLine("可");
            else if (input >= 0 && input < 60)
                Console.WriteLine("不可");
            else
                Console.WriteLine("範囲外");
        }
    }
}