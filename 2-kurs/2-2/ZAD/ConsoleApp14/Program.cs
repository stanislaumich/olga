using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Insert N=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert M=");
            int m = Convert.ToInt32(Console.ReadLine());
            var a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[m];
            }
            Console.Write("Insert A[N,M]");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j< m; j++)
                {
                    a[i][j] = Convert.ToInt32(Console.ReadLine()); 
                }
                Console.WriteLine("");
            }
            Console.WriteLine("A[N,M]=");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            int pos = 0;
            int neg = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i][j] > 0) { pos += 1;  }
                    if (a[i][j] < 0) { neg += 1; }
                }                
            }
            if (pos == neg) { Console.WriteLine("Equal"); }
            else {
                if (pos > neg) { Console.WriteLine("More Positive"); }
                else { Console.WriteLine("More Negative"); }
            }
        }
    }
}
