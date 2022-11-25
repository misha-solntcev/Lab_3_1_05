using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5. Дано целое число N (> 0), являющееся некоторой степенью 
    числа 2: N = 2^K. Найти целое число K — показатель этой степени. */

namespace Lab_3_1_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 2;

            int degree = 0;
            while (N > 1)
            {
                N /= 2;
                degree++;
            }
            Console.WriteLine(degree);
            Console.ReadKey();
        }
    }
}
