using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem7_2;

namespace Problem7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            c.Number1 = 8;    //  ��ڂ̐����Z�b�g
            c.Number2 = 9;    //  ��ڂ̐����Z�b�g
            //  ��̐��̘a��\��
            Console.WriteLine("{0} + {1} = {2}", c.Number1, c.Number2, c.Add());
            //  ��̐��̍���\��
            Console.WriteLine("{0} - {1} = {2}", c.Number1, c.Number2, c.Sub());
        }
    }
}