using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static double Sq(double a, double f, double c)
        {
            double p = (a + f + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - f) * (p - c));
            return S;
        }
        static void Main()
        {
            double a = 10;
            double b = 11;
            double c = 15;
            Console.WriteLine(Sq(a, b, c));
            Console.ReadLine();
        }
    }
}
