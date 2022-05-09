using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, a, dx, x0, xe;
            Console.WriteLine("Vvedite chislo a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite chislo x0");
            x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite chislo dx");
            dx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite chislo xe");
            xe = Convert.ToDouble(Console.ReadLine());

            x = x0;
            do
            {
                Console.Write("x=");
                Console.Write(x);
                Console.Write("   y=");
                y = a * Math.Log(x);
                Console.WriteLine(y);
                x += dx;
            }
            while (x < xe+dx);
        }
    }
}
