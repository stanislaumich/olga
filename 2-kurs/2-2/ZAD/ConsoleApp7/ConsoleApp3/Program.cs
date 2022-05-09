using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            double[,] mas = new double[7, 7];
            Random rd = new Random();
            for (int i=0; i<7; i++)
            {
                for (int j=0; j<7; j++)
                {
                    mas[i, j] = rd.Next(-20, 20);
                    Console.Write("{0}\t", mas[i, j]);
                }
                Console.WriteLine();
                
            }
            for(int j=0; j<7; j++)
            {
                double min = mas[0, j];
                for (int k=0; k<7; k++)
                {
                    if(mas[k,j]<min) { min = mas[k, j]; }
                }
                Console.WriteLine(min);
            }
            Console.ReadLine();
        }
       
    }
}
