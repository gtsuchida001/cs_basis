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
            int []data = new int[10];
            for (int index = 0; index < data.Length; index++)
            {
                Random random = new Random();
                data[index] = random.Next(1, 11);
                Console.Write("{0}", data[index]);
                if (data[index] != data[^1])
                    Console.Write(" ");
            }
            Console.WriteLine();
            int max = 0;
            int min = 10;
            int ave= 0;
            for (int index = 0; index < data.Length; index++){
            
                if (max < data[index])
                    max = data[index];
                if (min > data[index])
                    min = data[index];
            }
            for (int index = 0; index < data.Length; index++)
                ave += data[index];
            ave /= data.Length;
            Console.WriteLine("最大値：{0}", max);
            Console.WriteLine("最小値：{0}", min);
            Console.Write("平均値：{0}", ave);
            int t = Console.Read();
        }
    }
}