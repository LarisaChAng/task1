using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int s = 0;
            Console.WriteLine("Введите семь чисел одномерного массива");
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
            }
            Console.WriteLine("Среднеарифметическое чисел равно {0:f2}", ((double)s) / 7);
            Console.ReadKey();
        }
    }
}
