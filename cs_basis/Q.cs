using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basis
{
    class Program
    {
        static void Main()
        {
            int [,]data = new int[3,3];
            int max = 0;
            int min = 9;

            for (int index = 0; index < data.GetLength(0); index++)
            {
                for (int index2 = 0; index2 < data.GetLength(1); index2++)
                {
                    Random random = new Random();
                    data[index,index2] = random.Next(0, 10);
                    //Console.Write("{0}", data[index,index2]);
                    //if (data[index,index2] != data[index, data.GetLength(1) - 1])
                        //Console.Write(" ");
                }
            }
            for (int index = 0; index < data.GetLength(0); index++)
            {
                for (int index2 = 0; index2 < data.GetLength(1); index2++)
                {
                    Console.Write("{0}", data[index,index2]);
                    if (index2 != data.GetLength(1) - 1)
                        Console.Write(" ");
                    if (index != data.GetLength(0) - 1 && index2 == data.GetLength(1) - 1)
                        Console.WriteLine();
                }
            }

            for (int index = 0; index < data.GetLength(0); index++)
            {
                for (int index2 = 0; index2 < data.GetLength(1); index2++)
                {
                    if (data[index, index2] > max)
                        max = data[index, index2];
                    if (data[index, index2] < min)
                        min = data[index, index2];
                }
            }
            Console.WriteLine();

            Console.WriteLine("最大値：{0}", max);
            Console.Write("最小値：{0}", min);

            int t = Console.Read();
        }
    }
}