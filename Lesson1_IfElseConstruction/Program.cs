using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_IfElseConstruction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Конструкция if/else проверяет истинность некоторого условия и в зависимости от результатов проверки выполняет определенный код.

            //Пример 1
            bool isInfected = true;

            if(isInfected)
            {
                Console.WriteLine("Персонаж заражен!");
            }
            else
            {
                Console.WriteLine("Персонаж здоров!");
            }

            //Пример 2
            int a;

            a = Convert.ToInt32(Console.ReadLine());

            if(a == 5)
            {
                Console.WriteLine("a равно 5");
            }
            else
            {
                Console.WriteLine("a не равно 5");
            }


            Console.ReadLine();

        }
    }
}
