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
            Console.Write("a=");
            string? inputString = Console.ReadLine();
            if (!int.TryParse(inputString, out int result) || inputString == null)
                return;
            int inputa = int.Parse(inputString);
            Console.Write("b=");
            string? inputString2 = Console.ReadLine();
            if (!int.TryParse(inputString2, out int result2) || inputString2 == null)
                return;
            int inputb = int.Parse(inputString);
            if (inputa > inputb)
                Console.WriteLine("a={0} b={1}\naはbよりも大きい", inputa, inputb);
            else if (inputa < inputb)
                Console.WriteLine("a={0} b={1}\naはbよりも小さい", inputa, inputb);
            else
                Console.WriteLine("a=b={0}\naはbと等しい" , inputa);
        }
    }
}