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
            int []data = new int[7];
            List<int> case1 = new List<int>();
            List<int> case2 = new List<int>();
            List<int> case3 = new List<int>();

            for (int index = 0; index < data.Length; index++)
            {
                Random random = new Random();
                data[index] = random.Next(0, 101);
                Console.Write("{0}", data[index]);
                if (data[index] != data[^1])
                    Console.Write(" ");
            }
            Console.WriteLine("\n");
            for (int index = 0; index < data.Length; index++)
            {
                if (data[index] < 60 && data[index] >= 0)
                    case1.Add(data[index]);
                else if (data[index] >= 60 && data[index] < 80)
                    case2.Add(data[index]);
                else if (data[index] >= 80)
                    case3.Add(data[index]);
            }
            Console.WriteLine("0以上60未満：" + string.Join(" ", case1));
            Console.WriteLine("60以上80未満：" + string.Join(" ", case2));
            Console.Write("80以上：" + string.Join(" ", case3));
            int t = Console.Read();
        }
    }
}