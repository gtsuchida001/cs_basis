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
            Console.WriteLine("��ڂ̕������" + s.String1);
            Console.WriteLine("��ڂ̕������" + s.String2);
            Console.WriteLine("��̕�����������������̂�" + s.GetConnectedString());
        }
    }
}