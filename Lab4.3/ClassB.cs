using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4._3
{
    internal class ClassB
    {
        public int num1 = 2;
        public int num2 { get; private set; }
        public ClassB(string p1, string p2, int n2)
        {
            num2 = n2;
        }
        public void Calc(int n)
        {
            Console.WriteLine((n + num1) * num2);
        }
    }
}