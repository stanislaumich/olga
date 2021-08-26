/*
Решите задачу. Дан двумерный массив n х n. 
Заполните его по строкам с клавиатуры. 
Определите максимальный элемент в побочной 
диагонали и поменяйте местами столбец 
содержащего его с первым столбцом.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива n:");
            int n = Int32.Parse(Console.ReadLine());
            int[,] a = new int[n, n];//объявление массива
            Console.WriteLine("Размер масива: [{0}x{1}]", n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Заполните элемент массива A[{0},{1}]", i + 1, j + 1);
                    a[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            // вывод  массива
            for (int i = 0; i < n; i++)
            {// перебираем столбцы
                for (int j = 0; j < n; j++)
                {// перебираем элементы столбца 
                    Console.Write(a[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine("");
            }
            // поиск столбца с максимальным элементом
            int r = 0;
            int m = a[0, n - 1];
            for (int i = 0; i < n; i++) {//цикл  по элементам
                if (a[i, n - i - 1] > m) {// сравниваем элемент побочной диагонали с максимальным
                    m = a[i,n - i - 1];//  обновляем максимальный
                    r = i;// запоминаем столбец
                        }
            }
            // выводим промежуточный результат 
            // и запросим номер столбца обмена
            Console.WriteLine("Координаты максимального элемента i: {0} j:{1}", r + 1, n - r);
            Console.WriteLine("Максимальный элемент: {0}", m);
            Console.WriteLine("Номер столбца c которым поменять столбец {0}:", n - r);
            int s = Int32.Parse(Console.ReadLine())-1;  // считываем номер столбца
                                                      // совершаем сам обмен
            int t = 0;
            for (int i = 0; i < n; i++) {
                t = a[i, n - r - 1];
                a[i, n - r - 1] = a[i, s];
                a[i, s] = t;
            }
            // вывод результирующего массива
                for (int i = 0; i < n; i++)
            {// перебираем столбцы
                for (int j = 0; j < n; j++)
                {// перебираем элементы столбца 
                    Console.Write(a[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Нажмите ВВОД");
            Console.ReadLine();
        }
    }
}
