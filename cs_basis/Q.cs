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

            List<int> over_0 = new List<int>();
            List<int> under_0 = new List<int>();
            List<int> zero = new List<int>();


            for (int index = 0; index < data.Length; index++)
            {
                Random random = new Random();
                data[index] = random.Next(0, 100);
                Console.Write("{0}", data[index]);
                if (data[index] != data[^1])
                    Console.Write(" ");
            }
            Console.WriteLine();
            for (int index = 0; index < data.Length; index++)
            {
                if (data[index] > 49){
                    over_0.Add(data[index]);
                }
                if (data[index] < 50)
                {
                    under_0.Add(data[index]);
                }
                if (data[index] == 0)
                {
                    zero.Add(data[index]);
                }
            }
            Console.WriteLine("50以上の数：" + string.Join(" " , over_0));
            Console.WriteLine("50未満の数：" + string.Join(" ", under_0));
            Console.Write("0の数：" + string.Join(" ", zero));
            int t = Console.Read();
        }
    }
}