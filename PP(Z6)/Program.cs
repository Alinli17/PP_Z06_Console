using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива (одномерный): ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine("Введите размерность массива (двумерный): ");
            Console.Write("Кол-во строк в массиве: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Кол-во столбцов в массиве: ");
            int m2 = int.Parse(Console.ReadLine());
            int[,] b = new int[n2, m2];

            int sum = 0;
            int summ = 0;

            for (int i = 0; i < n; ++i)
                {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] % 9 == 0)
                {
                    sum+= a[i];
                }
            }
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < n2; ++i)
                for (int j = 0; j < m2; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    b[i, j] = int.Parse(Console.ReadLine());
                    if (b[i, j] % 9 == 0)
                    {
                        summ += b[i, j];
                    }
                }
            Console.WriteLine("Одномерный массив: Сумма элементов, кратных 9 = " + sum);
            Console.WriteLine("Двумерный массив: Сумма элементов, кратных 9 = " + summ);
            Console.ReadKey();
        }
    }
}
