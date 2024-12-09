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
                data[index] = random.Next(1, 101);
                Console.Write("{0} ", data[index]);
            }
            Console.WriteLine();
            int i = 0;
            Console.Write("奇数：");
            while (i < 10){
                {
                    if (data[i] % 2 != 0){
                        Console.Write("{0}", data[i]);
                        if (i != 9)
                            Console.Write(" ");
                    }
                }
                i++;
            }
            Console.WriteLine();
            i = 0;
            Console.Write("偶数：");
            while (i < 10){
                if (data[i] % 2 == 0){
                    Console.Write("{0}", data[i]);
                    if (i != 9)
                        Console.Write(" ");
                }
                i++;
            }
            int t = Console.Read();
        }
    }
}