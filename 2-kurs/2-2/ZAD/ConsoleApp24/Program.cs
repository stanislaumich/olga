using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Insert N");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n,n];
            int s = 0;
            int k = 0;
            double sr = 0.0;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(0, 9);
                    Console.Write("{0,3}",a[i,j]);
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    s+=a[i, j];
                    k += 1;
                }               
            }
            sr = 1.0 * s / k;
            Console.WriteLine("");
            Console.WriteLine("Number N={0}",k);
            Console.WriteLine("Summa S={0}",s);
            Console.WriteLine(String.Format("Sred Arif SR={0:F2}", sr));
           
        }
    }
}
