using System;

namespace Exercise1
{
    class Program
    {
        /*
	Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
	*/

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5,5));
            Console.WriteLine(Sum(12, 10));
            Console.WriteLine(Sum(-5, 2));
            Console.ReadLine();

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

