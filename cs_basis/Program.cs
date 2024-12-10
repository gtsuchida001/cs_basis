using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            d.DataNumber = 100;
            d.DataComment = "Programming C#";
            Console.WriteLine("number = " + d.DataNumber);
            Console.WriteLine("comment = " + d.DataComment);
        }
    }
}