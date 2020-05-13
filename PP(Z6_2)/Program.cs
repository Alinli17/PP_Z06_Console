using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int buffer;
            Console.Write("Введите размер матрицы: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mas = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Первоначальный вариант:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            if (n % 2 == 0)
            {
                for (int i = 0; i < n; i += 2)
                {
                    for (int j = 0; j < n; j++)
                    {
                        buffer = mas[j, i];
                        mas[j, i] = mas[j, i + 1];
                        mas[j, i + 1] = buffer;
                    }
                }
                Console.WriteLine("Изменённый вариант:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(mas[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            Console.Write("Массив нечетный!");
            Console.ReadKey();
        }
    }
}
