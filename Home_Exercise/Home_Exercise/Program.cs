using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 2));
            Console.WriteLine(Sum(12, 10));
            Console.WriteLine(Sum(-5, 2));
        }

        static int Sum(int a, int b)
        {
            if (a == b)
            {
                return a + b;
            }
            else
            {
                return (a + b) * 3;
            }


        }
    }
}

