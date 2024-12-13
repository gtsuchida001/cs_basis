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
//            Random random = new Random();
//            int number = random.Next(2, 101);
//            int[] array = Enumerable.Range(2, 99).ToArray();
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] != 0)
//                {
//                    for (int j = i + array[i]; j < array.Length; j += array[i])
//                        array[j] = 0;
//                }
//            }
//            int[] prime = array.Where(x => x != 0).ToArray();
//            Console.Write(number + " = " );
//            for (int i = 0; i < prime.Length; i++)
//            {
//                while (number % prime[i] == 0)
//                {
//                    if (number / prime[i] == 1)
//                        Console.Write(prime[i]);
//                    else
//                        Console.Write(prime[i] + " * ");
//                    number /= prime[i];
//                }
//            }
//        }
//    }
//}