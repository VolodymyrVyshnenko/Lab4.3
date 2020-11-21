using System;
using System.Diagnostics;


namespace Lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA("qwe", "rty");
            ClassB b = new ClassB("q", "w", 22);
            b.Calc(3);
            Debug.WriteLine(b.num2);
            Debug.WriteLine(b.num1);
        }
    }
}
