using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20] { 18, 8, 3, 5, -6, 8, -20, -1, 3, 15, 20, 11, -9, 6, 14, -2, 5, 11, 3, -9 };
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,4}", a[i]);
                //Console.Write("  ");
            }
            Console.WriteLine("  ");
            for (int i = 0; i < 20; i++)
            {
                a[i] = a[i] / Math.Abs(a[i]);
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,4}", a[i]);
                //Console.Write("  ");
            }

        }
    }
}
