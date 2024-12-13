using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basis
{
    class Program
    {
        static void Main(string[] args)
        {
            string? i = Console.ReadLine();
            int j = 0;
            if (int.TryParse(i, out j)){

                int k = j;
                if (j == 0)
                {
                    j = 1;
                    Console.Write(j);
                    return;
                }
                for (int index = j; index > 0; index--)
                {
                    j *= index;
                }
                j = j / k;
            }
            Console.Write(j);
        }
    }
}