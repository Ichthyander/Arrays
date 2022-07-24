using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. 
 * Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
 * Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.*/

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность квадратной матрицы");
            int N = Convert.ToInt32(Console.ReadLine());
            //Array declaration
            int[,] array = new int[N, N];

            //Array initialisation
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите значения матрицы на строке {0}", (i+1));
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int horSum, vertSum, diagSum;
            horSum = vertSum = diagSum = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", array[i, j]);

                    if (i == 0)
                    {
                        horSum += array[i, j];
                    }

                    if (j == 0)
                    {
                        vertSum += array[i, j];
                    }

                    if (i == j)
                    {
                        diagSum += array[i, j];
                    }
                }
                Console.WriteLine();
            }

            if ((horSum == vertSum) && (vertSum == diagSum))
            {
                Console.WriteLine("Введенная матрица является магическим квадратом");
            }
            else
            {
                Console.WriteLine("Введенная матрица НЕ является магическим квадратом");
            }

            Console.ReadKey();
        }
    }
}
