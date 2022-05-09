using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double y,f;
            Console.WriteLine("Vvedite chislo");
            y = Convert.ToDouble(Console.ReadLine());
            if (y<=-4)
            {
                f = (-1) * Math.Sin(2 * y) + 4;
                Console.WriteLine(f);
                Console.ReadLine();
            }
            else
            {
                if(y>5)
                {
                    f = Math.Cos(4 * y) / 6;
                    Console.WriteLine(f);
                    Console.ReadLine();
                }
                else
                {
                    f = Math.Sqrt(1 + y * y);
                    Console.WriteLine(f);
                    Console.ReadLine();
                }
            }
        }
    }
}
