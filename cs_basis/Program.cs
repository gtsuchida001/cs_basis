using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMax m = new MinMax();
            int a = 4, b = 2 ,c= 0;
            Console.WriteLine("{0}Ç∆{1}Ç∆{2}ÇÃÇ§ÇøÅAç≈ëÂÇÃÇ‡ÇÃÇÕ{3}", a, b, c,m.Max(a, b,c));
            Console.WriteLine("{0}Ç∆{1}Ç∆{2}ÇÃÇ§ÇøÅAç≈è¨ÇÃÇ‡ÇÃÇÕ{3}", a, b, c,m.Min(a, b,c));
        }
    }
}