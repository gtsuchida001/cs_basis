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
//            int[] array = new int[10];
//            for (int i = 0; i < array.Length; i++)
//                array[i] = random.Next(1, 101);
//            Console.WriteLine("元の数: " + string.Join(", ", array));
//            for (int i = 0; i < array.Length - 1 ; i++)
//            {
//                int maxindex = i;
//                for (int j = i + 1; j < array.Length; j++)
//                {
//                    if (array[j] > array[maxindex])
//                        maxindex = j;
//                }
//                int temp = array[i];
//                array[i] = array[maxindex];
//                array[maxindex] = temp;
//            }
//            Console.Write("整列後: " + string.Join(", ", array));
//        }
//    }
//}