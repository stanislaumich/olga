/*
 * 73 Напишите программу, которая выводит на экран таблицу значений функции y=sqrt(abs(2x-5))
 * в диапазоне от -2 до 2. Шаг изменения аргумента 0,1.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double x = -2;
            double step = .1;
            do
            {
                y = Math.Sqrt(Math.Abs(2*x-5));
                Console.WriteLine("x={0}   y={1}", Math.Round(x,2), Math.Round(y,2));
                x += step;
            }
            while (x <= 2.1);
            Console.WriteLine("Работа завершена, нажмите ВВОД");
            Console.Read();
        }
    }
}
