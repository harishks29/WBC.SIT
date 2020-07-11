using System;

namespace WBC.SIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            Add(2, 3);
        }

        static void Print()
        {
            Console.WriteLine("Hello GIT");
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}