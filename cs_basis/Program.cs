using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            //  �~�̔��a��ݒ�
            c.r = 4.0;
            Console.WriteLine("���a" + c.r + "�̉~�̉~���̒�����" + c.Circumference());
            Console.Write("���a" + c.r + "�̉~�̖ʐς̑傫����" + c.Area());
        }
    }
}