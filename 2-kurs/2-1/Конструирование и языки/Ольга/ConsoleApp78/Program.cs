/*
 * Решите задачу. Дан двумерный массив. Заполните его по строкам с клавиатуры и определите:
-	количество столбцов, не содержащих ни одного нулевого элемента;
-	минимальное из чисел, в заданном столбце массива.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 2; //число строк
            const int m = 3; //число столбцов
            int bd;
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
            // вывод массива
            for (int i = 0; i < n; i++)
            {// перебираем столбцы
                for (int j = 0; j < m; j++)
                {// перебираем элементы столбца сравнивая 2 соседних
                    Console.Write(A[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine("");
            }
            // поиск количества столбцов без 0
            int s=0;// количество
            for (int j = 0; j < m; j++)
            {// перебираем столбцы
                bd = 1;
                for (int i = 0; i < n ; i++)
                    {// перебираем элементы столбца 
                        if (A[i, j] == 0)
                        {//  если есть 0
                            bd=0;
                        }
                    }
                s += bd;// добавляем ненулевой столбец
            }
            Console.WriteLine("Столбцов без нулей: {0}",s);
            Console.WriteLine("Укажите столбец: ");
            s  = Int32.Parse(Console.ReadLine())-1;// столбец для поиска минимума
            int mn = A[0, s];
            for (int i = 0; i < n; i++)
            {
                if (A[i, s] < mn) { mn = A[i, s]; }// обновляем минимум если надо
            }
            Console.WriteLine("Минимальный элемент: {0}", mn);
            
            Console.WriteLine("Нажмите ВВОД");
            Console.ReadLine();

        }
    }
}
