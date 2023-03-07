using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*     Логические операторы
             *    
             *    && - Сокращенное и
             *    || - Сокращенное или
             *    & - и
             *    | - или
             *    ! - не ( унарный )
             * 
             */

            bool isInfected = false;

            //Пример 1
            if (!isInfected)
            {
                Console.WriteLine("Персонаж здоров!");
            }

            //Пример 2

            int fanSpeed = 3000;

            bool isHighTemperature = true;

            bool hasNoCooling = fanSpeed <= 0;

            if(isHighTemperature || hasNoCooling)
            {
                Console.WriteLine("Угроза повреждение процессора!");
            }
            

            Console.ReadLine();

        }
    }
}
