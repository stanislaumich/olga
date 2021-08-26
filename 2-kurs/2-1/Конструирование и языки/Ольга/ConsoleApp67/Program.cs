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
            int x = 2;// начальное значение
            int step = 1;// шаг
            do
            {
                s += 1/(x*(x+1)); //вычисляем значение функции
                Console.WriteLine("ШАГ={0}   y={1}",x-1, y );// выводим результат
                x += step;// приращаем аргумент шага
            }
            while (x <= 2.1);// проверяем условие окончания
            Console.WriteLine("Работа завершена, нажмите ВВОД");
            Console.Read();
        }
    }
}
