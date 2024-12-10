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
            //  ‰~‚Ì”¼Œa‚ğİ’è
            c.r = 4.0;
            Console.WriteLine("”¼Œa" + c.r + "‚Ì‰~‚Ì‰~ü‚Ì’·‚³‚Í" + c.Circumference());
            Console.Write("”¼Œa" + c.r + "‚Ì‰~‚Ì–ÊÏ‚Ì‘å‚«‚³‚Í" + c.Area());
        }
    }
}