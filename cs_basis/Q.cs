﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0 && i != 100)
                    Console.WriteLine(i);
                else
                    Console.Write(i + " ");
            }
        }
    }
}