using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert x");
            double x = Convert.ToDouble(Console.ReadLine());
            Double F = 0;
            if (x<1 & c!=0)
            {
                F = a * Math.Pow(x, 2) + b / c;
                Console.WriteLine(F);
            }
            else if (x>15 & c==0)
            {
                F = (x - a) / (Math.Pow(x - c, 2));
                Console.WriteLine(F);
            }
            else
            {
                F = Math.Pow(x, 2) / Math.Pow(c, 2);
                Console.WriteLine(F);
            }

        }
    }
}
