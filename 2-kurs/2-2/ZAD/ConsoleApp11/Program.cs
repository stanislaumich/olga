using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "734нироаыти5644121 _еррку%:6753674";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i])) { 
                    Console.WriteLine(s[i]);
                }
            }
            ;
        }
    }
}
