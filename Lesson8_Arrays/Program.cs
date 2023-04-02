using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Arrays
{
    /*
     * Массивы 
     * 
     * Одномерные массивы, инициализация, объявление, вывод, перебор
     * 
     * Тип элементов массива[] имя массива 
     * 
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            //СПОСОБЫ ИНИЦИАЛИЗАЦИИ МАССИВА
            //1) Сразу при объявлении массива выделяем ему память 
            int[] myArray = new int[5];

            //2) Сразу указываем элементы
            int[] myArray2 = new int[5] {1, 2, 3, 4, 5};

            //3) Сразу указываем элементы, но не указываем в скобках его размер
            int[] myArray3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //4) Сразу указываем элементы, упрощенный вариант
            int[] myArray4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Заполнить каким-то одним значением 
            int[] myArray5 = Enumerable.Repeat(5, 10).ToArray();

            //Последовательно заполнение массива пятью элементами начиная с 4 
            int[] myArray6 = Enumerable.Range(4, 5).ToArray();

            //ВЫВОД МАССИВА В КОНСОЛЬ
            //Вывод в консоль через цикл for
            for(int i = 0; i < myArray3.Length; i++)
            {
                Console.WriteLine(myArray3[i]);
            }

            //НЕКОТОРЫЙ ФУНКЦИОНАЛ МАССИВОВ
            //массивы являются наследниками класса Array
            int[] testArray = { 111, 10, 4, 99, 49, 64, 77, 4, 42, 5 };

            //Минимальный элемент массива
            int minElement = testArray.Min();

            //Максимальный элемент массива
            int maxElement = testArray.Max();

            //Сумма элемента массива 
            int sumAray = testArray.Sum();

            //Сумма четных чисел. Where - позволяет поместить в себя условие для поиска, принимает делегат
            int sumOnEvenNumbers = testArray.Where(i => i % 2 == 0).Sum();

            //Оставить только уникальные элементы 
            int[] invertedArray = testArray.Distinct().ToArray();

            //Сортировка массива через статический метод класса Array
            Array.Sort(testArray);

            //Поиск определенного элемента по условию 
            Array.Find(testArray, i => i < 70);

            //Поиск всех элементов, удовлетворяющих условию
            int[] result = Array.FindAll(testArray, i => i < 70);

            //Найти индекс по условию 
            int resultIndex = Array.FindIndex(testArray, i => i == 111);

            //Перевернуть массив 
            Array.Reverse(testArray);

            int resultSecond = testArray.Where(i => i < 70).FirstOrDefault();







            Console.ReadLine();
        }
    }
}
