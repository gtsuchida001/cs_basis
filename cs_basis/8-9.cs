//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace cs_basis
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            int[] array = new int[10];
//            int odd = 0;
//            int even = 0;
//            int a = 0;
//            int b = 0;
//            for (int i = 0; i < array.Length; i++)
//                array[i] = random.Next(1, 100);
//            for (int i = 0; i < array.Length; i++)
//                Console.Write(array[i] + " ");
//            Console.WriteLine();
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] % 2 == 0)
//                    odd++;
//                else
//                    even++;
//            }
//            int[] oddarray = new int[odd];
//            int[] evenarray = new int[even];
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] % 2 == 0)
//                {
//                    oddarray[a] = array[i];
//                    a++;
//                }
//                else
//                {
//                    evenarray[b] = array[i];
//                    b++;
//                }
//            }
//            Console.Write("‹ô”F");
//            for (int i = 0; i < evenarray.Length; i++)
//                Console.Write(evenarray[i] + " ");
//            Console.WriteLine();
//            Console.Write("Šï”F");
//            for (int i = 0; i < oddarray.Length; i++)
//                Console.Write(oddarray[i] + " ");
//        }
//    }
//}