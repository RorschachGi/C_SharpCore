using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_FunctionsAndMethods
{

    /*
     * Функции и методы в с#
     * C# объектно-ориентированный язык, где  функция не может существовать без класса, а функции, принадлежащий классу принято
     * называть методами.
     */

    //модификаторы тип_возвращаемого_значения название_Метода(параметры){
    // тело функции
    //}
    internal class Program
    {

        /// <summary>
        /// Возвращает сумму двух целых чисел 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b; //возвращаемое значение 
        }

        //Перегрузка метода Sum()
        /// <summary>
        /// Вовзращает сумму трех целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c; //возвращаемое значение 
        }


        //void - на случай, если вовзвращать значение из функции не нужно
        static void PrintLine()
        {
            Console.WriteLine("Метод PrintLine был вызван");
        }

        static void PrintString(char str, uint count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.Write(str);
            }
        }

        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());

            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);

            Console.WriteLine(c);

            Console.WriteLine("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;

           

            Console.WriteLine("\nВведите количество символов: ");
            uint countSymbol = uint.Parse(Console.ReadLine());
            PrintString(symbol, countSymbol);

            Console.ReadLine();
        }
    }

}
