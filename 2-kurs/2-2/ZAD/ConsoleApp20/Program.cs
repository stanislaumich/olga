using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert N ");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }


            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,4}",a[i]);
                
            }
            Console.WriteLine("  ");
            int s = 0;
            for (int i = 1; i < n; i+=2)
            {
                s += a[i];
            }
            Console.WriteLine(" Sum={0}", s);
        }
    }
}
