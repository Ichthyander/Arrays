using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида
1 0 1 0 1

0 1 0 1 0

1 0 1 0 1

0 1 0 1 0

1 0 1 0 1*/

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность квадратной матрицы");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = ( (((i + j) % 2) == 0)) ? 1 : 0;
                    Console.Write("{0} ", array[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
