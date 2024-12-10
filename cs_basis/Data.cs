using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_1
{
    class Data
    {
        //  メンバ変数number
        private int number = 0;
        //  メンバ変数comment
        private string Comment = "";
        public int DataNumber
        {
            get { return number; }
            set { number = value; }
        }
        public string DataComment
        {
            get { return Comment; }
            set { Comment = value; }
        }
    }
}