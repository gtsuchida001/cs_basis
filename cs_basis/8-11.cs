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
//            int[] array1 = new int[10];
//            int[] array2 = new int[10];
//            for (int i = 0; i < array1.Length; i++)
//            {
//                array1[i] = random.Next(1, 11);
//                array2[i] = random.Next(1, 11);
//            }
//            Console.WriteLine("配列1: " + string.Join(", ", array1));
//            Console.WriteLine("配列2: " + string.Join(", ", array2));

//            int[] array3 = array1.Intersect(array2).OrderBy(x => x).ToArray();
//            int[] temp = array1.Union(array2).OrderBy(x => x).ToArray();
//            int[] array4 = temp.Except(array3).OrderBy(x => x).ToArray();


//            Console.WriteLine("共通する値: " + string.Join(", ", array3));
//            Console.WriteLine("どちらかに入る値: " + string.Join(", ", array4));
//        }
//    }
//}