/*
  62 Напишите программу, которая определяет максимальное число из введенной с клавиатуры последовательности положительных чисел (длина последовательности неограниченна). Ниже приведен ре-комендуемый вид экрана во время выполнения программы (данные, введенные пользователем, выделены  полужирным шрифтом). Определение максимального числа последовательности положительных чисел.
  Пример: Вводите после стрелки числа. Для завершения ввода введите ноль,
- > 56
- > 75
- >43
- >0
Максимальное число: 75
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;// число введенное с клавиатуры
                  // 
            int m = 0; // максимальное число
            Console.WriteLine("Вычисление максимального числа последовательности");
            Console.WriteLine("Для окончания введите 0");
            do
            {
                Console.Write("->");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > m)
                {
                    m = n;
                }
            }
            while (n > 0);
            Console.WriteLine("Максимальное число: " + m);
            Console.WriteLine("Нажмите ВВОД ");
            Console.ReadLine();
        }
    }
}
