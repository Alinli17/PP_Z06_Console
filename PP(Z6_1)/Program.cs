using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z6_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива (одномерный): ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int max = a[0];
            int imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    imax = i;
                    break;
                }
            }
            Console.WriteLine("Номер первого максимального элемента: " + imax);
            Console.ReadKey();
        }
    }
}
