using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_2
{
    class Calculation
    {
        private int number1;
        private int number2;

        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }
        public int Add()
        {
            return Number1 + Number2;
        }
        public int Sub()
        {
            return Number1 - Number2;
        }
    }
}