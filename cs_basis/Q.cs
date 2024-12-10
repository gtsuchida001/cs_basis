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
            int []data = new int[5];

            int i = 0;
            int j = 0;
            List<int> over_ave = new List<int>();
            List<int> under_ave = new List<int>();
            int sum = 0;
            int ave = 0;

            for (int index = 0; index < data.Length; index++)
            {
                Random random = new Random();
                data[index] = random.Next(1, 11);
                Console.Write("{0}", data[index]);
                if (data[index] != data[^1])
                    Console.Write(" ");
            }
            Console.WriteLine();
            for (int index = 0; index < data.Length; index++)
                sum += data[index];
            ave = sum / data.Length;
            for (int index = 0; index < data.Length; index++)
            {
                if (data[index] > ave){
                    over_ave.Add(data[index]);
                }
                if (data[index] < ave)
                {
                    under_ave.Add(data[index]);
                }
            }
            Console.WriteLine("平均値より大きい数：" + string.Join(" " , over_ave));
            Console.Write("平均値より小さい数：" + string.Join(" ", under_ave));
            int t = Console.Read();
        }
    }
}