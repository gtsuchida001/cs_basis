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
            for (int index = 100; index > 0; index--)
            {
                if (index % 3 == 0)
                    Console.WriteLine("{0}", index);
            }
        }

        
    }
}