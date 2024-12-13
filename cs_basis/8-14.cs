//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace cs_basis
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int limit = 10000;
//            for (int a = 1; a <= limit; a++)
//            {
//                int b = SumOfDivisors(a);
//                if (b > a && b <= limit && SumOfDivisors(b) == a)
//                    Console.WriteLine($"({a}, {b})");
//            }
//        }
//        static int SumOfDivisors(int n)
//        {
//            int sum = 0;
//            for (int i = 1; i <= n / 2; i++)
//            {
//                if (n % i == 0)
//                    sum += i;
//            }
//            return sum;
//        }
//    }
//}