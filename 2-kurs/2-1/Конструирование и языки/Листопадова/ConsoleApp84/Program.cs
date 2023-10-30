/*
 * 84 Решите задачу. Дан двумерный массив. 
 * Заполните его по строкам с клавиатуры.
 * Отсортируйте каждый столбец по возрастанию.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 2; //число строк
            const int m = 3; //число столбцов
            int[,] A = new int[n, m];//объявление массива
            Console.WriteLine("Размер масива: [{0}x{1}]", n, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Заполните элемент массива A[{0},{1}]", i + 1, j + 1);
                    A[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            // сортировка массива по столбцам
            int s;
            for (int j = 0; j < m; j++)
            {// перебираем столбцы
                for (int k = 0; k < n; k++)
                { // повторяем несколько проходов
                    for (int i = 0; i < (n - 1); i++)
                    {// перебираем элементы столбца сравнивая 2 соседних
                        if (A[i, j] > A[i + 1, j])
                        {//  если не отсортировано
                            s = A[i, j]; // меняем элементы местами
                            A[i, j] = A[i + 1, j];
                            A[i + 1, j] = s;
                        }

                    }
                }
            }
            // вывод результирующего массива
            for (int i = 0; i < n; i++)
            {// перебираем столбцы
                for (int j = 0; j < m; j++)
                {// перебираем элементы столбца сравнивая 2 соседних
                    Console.Write(A[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Нажмите ВВОД");
            Console.ReadLine();
        }
    }
}
