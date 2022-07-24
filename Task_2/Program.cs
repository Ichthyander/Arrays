using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Сформировать одномерный массив из 15 элементов, которые выбираются случайным 
 * образом из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.*/

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random rnd = new Random();
            //instantiating initial max/min values
            int min = 50;
            int max = 0;

            Console.WriteLine("Массив");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(50);
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }

                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Максимальное значение в массиве = {0}", max);
            Console.WriteLine("Минимальное значение в массиве = {0}", min);
            Console.ReadKey();
        }
    }
}
