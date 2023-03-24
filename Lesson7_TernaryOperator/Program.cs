using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_TernaryOperator
{
    /*
     * 
     * Тернарный оператор
     * 
     * [первый оператор - условие] ? [второй операнд if_true] : [третий операнд if_false]
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed;

            string password = "qwerty";

            string enteredPassword = Console.ReadLine();

            //Обычная конструкция 
            /*
            if(password == enteredPassword)
            {
                accessAllowed = true;
            }
            else
            {
                accessAllowed = false;
            }*/

            //Синтаксис тернартного оператора
            accessAllowed = (password == enteredPassword) ? true : false;

            

            Console.WriteLine(accessAllowed);

            Console.ReadLine();
        }
    }
}
