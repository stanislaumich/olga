using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Insert N=");
            int n = Convert.ToInt32(Console.ReadLine());
            var a = new double[20];
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
                if (i == 0) { m = a[i]; }
                else
                {
                    if (a[i] < m) { m = a[i]; }
                }

            }
            Console.Write("Min="); Console.WriteLine(m);
            for (int i = 0; i < n; i++)
            {
               if (a[i] > 0) { strt = i+1;break; } 

            }
            for (int i = n; i >=0; i--)
            {
                if (a[i] > 0) { stp = i-1; break; }

            }
            Console.Write("Start="); Console.WriteLine(strt);
            Console.Write("Stop="); Console.WriteLine(stp);
            s = 0;
            for(int i = strt; i <= stp; i++)
            {
                s += a[i];
            }
            Console.Write("SUM="); Console.WriteLine(s);
        }
    }
}
