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
//            int[] array = Enumerable.Range(2, 99).ToArray();
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] != 0)
//                {
//                    for (int j = i + array[i]; j < array.Length; j += array[i])
//                        array[j] = 0;
//                }
//            }
//            int[] result = array.Where(x => x != 0).ToArray();
//            Console.Write("素数: " + string.Join(", ", result));
//        }
//    }
//}