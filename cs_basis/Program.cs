using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoStrings s = new TwoStrings();
            s.String1 = "Hello";
            s.String2 = "World";
            Console.WriteLine("ˆê‚Â–Ú‚Ì•¶š—ñ‚Í" + s.String1);
            Console.WriteLine("“ñ‚Â–Ú‚Ì•¶š—ñ‚Í" + s.String2);
            Console.WriteLine("“ñ‚Â‚Ì•¶š—ñ‚ğ‡¬‚µ‚½‚à‚Ì‚Í" + s.GetConnectedString());
        }
    }
}