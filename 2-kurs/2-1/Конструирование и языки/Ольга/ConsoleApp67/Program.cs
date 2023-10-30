/*
 * 67 Вычислите приближенно значение бесконечной суммы с точностью до Е
 * S=1/(2*3)+1/(3*4),,,,,
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0;// значение функции
            double sp = 0;// предыдущее значение функции
            int x = 2;// начальное значение
            int step = 1;// шаг
            double c = 0;
            Console.WriteLine("Введите нужную точность:");
            double e= Convert.ToDouble(Console.ReadLine());
            c = x * (x + 1);
            s = s + 1 / c; //вычисляем значение функции
            Console.WriteLine("ШАГ={0}   S={1} SP={2} SP-S={3}", x - 1, s, sp, sp - s);// выводим результат
            x += step;// приращаем аргумент шага
            sp = s;
            do
            {
                c = x * (x + 1);
                sp = s;
                s =  s+ 1/c; //вычисляем значение функции
                Console.WriteLine("ШАГ={0}   S={1}  delta={2}", x-1, s,Math.Abs(sp-s) );// выводим результат
                x += step;// приращаем аргумент шага                
            }
            while (Math.Abs(sp-s) > e);// проверяем условие окончания
            Console.WriteLine("Работа завершена, нажмите ВВОД");
            Console.Read();
        }
    }
}
