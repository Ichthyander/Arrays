using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            float average = 0;

            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                average += array[i];
            }

            Console.WriteLine("Среднее арифметическое массива = {0}", average / array.Length);
            Console.ReadKey();
        }
    }
}
