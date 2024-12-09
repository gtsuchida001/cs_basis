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
            Console.Write("a,bに1から10までの数値を入力してください。");
            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out int result) || inputString == null)
                return;
            int input = int.Parse(inputString);
            Console.Write("a,bに1から10までの数値を入力してください。");
            string? inputString2 = Console.ReadLine();
            if (!int.TryParse(inputString2, out int result2) || inputString2 == null)
                return;
            int input2 = int.Parse(inputString2);
            if (input <=0 || input2 <= 0 || input > 10 || input > 10)
            {
                Console.WriteLine("1から10までの数値を入力してください。");
                return;
            }
            if (input == input2)
                Console.WriteLine("aとbは同じ値です。");
            else if (input < input2)
                Console.WriteLine("aはbより小さい値です。");
            else
                Console.WriteLine("aはbより大きい値です。");
        }
    }
}