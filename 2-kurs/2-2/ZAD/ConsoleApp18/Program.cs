using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[15] { 18, 8, 3, 5,-6, 8, -20, -1,3, 15, 20, 11,-9, 6, 14};
            for (int i = 0; i < 15; i++)
            {
                Console.Write(a[i]);
                Console.Write("  ");
            }
            Console.WriteLine("  ");
            for (int i = 0; i < 15; i++)
            {
                for(int j = i; j < 15; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }

            for (int i = 0; i < 15; i++)
            {
                Console.Write(a[i]);
                Console.Write("  ");
            }

        }
    }
}
