using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, t, p1, p2, p3;
            x = 14.26;
            y = -1.22;
            z = 3.5e-2;
            t=.564849;

            p1 = 2 * Math.Cos(x - Math.PI / 6);
            p2 = .5 + Math.Pow(Math.Sin(y), 2);
            p3 = 1 + Math.Pow(z,2) / (3-(Math.Pow(z,2)/5));
            t = p1 / p2 * p3;
            Console.Write("t=");
            Console.WriteLine(t);
        }
    
    }
}
