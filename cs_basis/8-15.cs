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
//            int open = 1;
//            int close = 0;
//            int[] locker = new int[50];

//            for (int i = 1; i < locker.Length; i++)
//            {
//                for (int j = i; j < locker.Length; j++)
//                {
//                    if (j % i == 0)
//                    {
//                        if (locker[j] == close)
//                            locker[j] = open;
//                        else
//                            locker[j] = close;
//                    }
//                }
//            }
//            int sum = 0;
//            for (int i = 0; i < locker.Length; i++)
//            {
//                if (locker[i] == open)
//                    sum++;
//            }
//            Console.WriteLine("開いているロッカーの数: " + sum);
//        }
//    }
//}