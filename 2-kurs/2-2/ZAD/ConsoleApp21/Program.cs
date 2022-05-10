using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert N=");
            int n = Convert.ToInt32(Console.ReadLine());
            var a = new double[n];
            double m, s;
            int strt, stp;
            strt = 0;
            stp = 0;
            m = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Insert N[");
                Console.Write(i);
                Console.Write("]=");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] == 0) { strt = i ; break; }

            }
            for (int i = n-1; i > 0; i--)
            {
                if (a[i] == 0) { stp = i ; break; }

            }
            s = 0;
            for (int i = strt; i <= stp; i++)
            {
                s += a[i];
            }
            Console.Write("SUM="); Console.WriteLine(s);

        }
    }
}
