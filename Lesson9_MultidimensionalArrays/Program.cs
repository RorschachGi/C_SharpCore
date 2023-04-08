using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_MultidimensionalArrays
{
    /*
     * Многомерные массивы
     * 
     * Двумерные массивы, инициализация, обращение к элементам
     * 
     * Зубчатые массивы ( ступенчатые ) 
     * 
     */


    internal class Program
    {
        static void Main(string[] args)
        {

            //Инициализация: тип_данных [,] имя массива
            int[,] array = new int[2, 3];

            array[0, 0] = 1;


            int[,] arraySecond = new int[2, 3]
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            //Вывод двумерного массива в консоль
            //GetLength() - для получения измерения, начиная с 0 
            for (int i = 0;i < arraySecond.GetLength(0); i++)
            {
                for(int j = 0; j < arraySecond.GetLength(1); j++)
                {
                    Console.Write(arraySecond[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Заполнение двумерного массива случайными числами
            Random rand = new Random();
            int[,] arrayThird = new int[2, 3];
            for (int i = 0; i < arrayThird.GetLength(0); i++)
            {
                for (int j = 0; j < arrayThird.GetLength(1); j++)
                {
                    arrayThird[i, j] = rand.Next(100);
                }
               
            }

            //Зубчатый массив по сути представляет собой массив массивов 
            int[][] myArray = new int[2][];

            int[,] myArray2 = new int[3, 5];

            //Rank - возвращает количество измерений массива 
            int myArrayRank = myArray.Rank; // 1 измерение, т.к одномерный массив состоящий из других одн.массивов
            int myArray2Rank = myArray2.Rank; // 2 измерения 

            int myArrayLenght = myArray.Length; // 2 - т.к одномерный массив состоящий из двух элементов ( других массивов )
            int myArray2Lenght = myArray2.Length; // 15 







            Console.ReadLine();

        }
    }
}
