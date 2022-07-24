using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();

            Console.WriteLine("Изначальный массив");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }

            //Implement insertion sort algoritm for the first 5 elements in array
            for (int i = 1; i < 5; i++)
            {
                int key = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j] > key))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            //Implement insertion sort algoritm for the last 5 elements in array
            for (int i = 8; i > 4; i--)
            {
                int key = array[i];
                int j = i + 1;
                while ((j <= array.Length - 1) && (array[j] < key))
                {
                    array[j - 1] = array[j];
                    j++;
                }
                array[j - 1] = key;
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Отсортированный массив");
            foreach (int element in array)
            {
                Console.Write("{0} ", element);
            }

            Console.ReadKey();
        }
    }
}
