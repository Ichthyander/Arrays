using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество  
 * нечетных положительных элементов, стоящих на четных местах.*/

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            int oddCount = 0;

            Console.WriteLine("Изначальный массив");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 50);
                Console.Write("{0} ", array[i]);

                if ((i % 2 != 0) && (array[i] % 2 != 0) && (array[i] > 0))
                {
                    oddCount++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах - {0}", oddCount);
            Console.ReadKey();
        }
    }
}
