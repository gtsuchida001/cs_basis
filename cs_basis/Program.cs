using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem6_1;

namespace Problem6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            double a = 4.1, b = 2.3;
            Console.WriteLine($"{a} + {b} = {Math.Round(c.Sum(a, b), 2)}");
            Console.WriteLine($"{a} - {b} = {Math.Round(c.Sub(a, b), 2)}");
            Console.WriteLine($"{a} * {b} = {Math.Round(c.Mul(a, b), 2)}");
            Console.WriteLine($"{a} / {b} = {Math.Round(c.Div(a, b), 2)}");
            //Console.WriteLine($"{a} / {b} = {c.Div(a, b)}");
        }
    }
}