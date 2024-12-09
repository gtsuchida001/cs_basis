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
            double []a = { 0.2, -5.1, 3.2, 1.8};
            for (int i = 0; i < a.Length; i++)
                Console.Write("a[{0}] = {1}  ", i, a[i]);
            string t = Console.ReadLine();
        }
    }
}