using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z6_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());

            int[][] mas = new int[n][];
            int[] mas2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                mas[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    mas[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas[j][i] > 0)
                    {
                        mas2[i] = mas[j][i];
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Первый массив:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Второй массив:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mas2[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
