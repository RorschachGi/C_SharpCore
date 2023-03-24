using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_NestedLoops
{
    internal class Program
    {

        //Создание случайного двумерно массива
        static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();

            var result = new int[rows, columns];

            //Перебираем двойной массив и заполняем его случайными числами
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }

            return result;
        }

        //Вывод двумерно массива в консоль
        static void PrintArray(int[,] array, int rows, int columns)
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int rows = 5;

            int columns = 10;

            var myArray = GetRandomArray(rows, columns);

            PrintArray(myArray, rows, columns);

            Console.ReadLine();
        }
    }
}
