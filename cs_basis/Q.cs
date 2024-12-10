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
            int i = 0;
            Console.Write("3の倍数：");
            while (i < data.Length)
            {
                if (data[i] % 3 == 0){
                    Console.Write("{0}", data[i]);
                    if (i != data.Length - 1)
                        Console.Write(" ");
                }
                i++;
            }
            i = 0;
            Console.WriteLine();
            Console.Write("3の倍数以外の数:");
            while (i < data.Length)
            {
                if (data[i] % 3 != 0){
                    Console.Write("{0}", data[i]);
                    if (i != data.Length - 1)
                        Console.Write(" ");
                }
                i++;
            }

            int t = Console.Read();
        }
    }
}