using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert L");
            string L=Console.ReadLine();
            if (L.Length % 2 == 1)
            {
                L = L.Remove(L.Length % 2 +2, 1);
            }
            else
            {
                if (L.IndexOf(' ') > 0) { L = L.Remove(0, L.IndexOf(' ')); }
            }
            
            Console.WriteLine(L);
        }
    }
}
