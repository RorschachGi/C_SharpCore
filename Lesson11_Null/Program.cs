using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Null
{

    /*
     * 
     * null
     * оператор null-объединения
     * оператор null-присваиваня объединения
     * оператор условного null
     * 
     */

    internal class Program
    {

        static void Foo()
        {
            int[] a = new int[10];
        }

        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }

        static void Main(string[] args)
        {

            /*
             * null может быть присвоено ссылочным типам. Оно устаналивается по умолчанию.
             * Ссылочные типы хранят свои данные в управляемой куче, в стеке хранится только ссылка
             * на эти данные. 
             */
            int[] array = new int[10];
            array = null;

            Foo();

            //оператор null-объединения ( ?? ) позволяет обработать null-значение и вывести значение по умолчанию 
            //Значение по умолчанию должно быть того же типа 
            string test = null;
            string result = test ?? "Пустая строка";
            Console.WriteLine(result);

            string str = null;
            string result2 = str ?? string.Empty;
            Console.WriteLine("Количество символов в строке: " + result2.Length);

            /*оператор null-призваивания-объединения ( ??= ) позволяет обработать null-значение 
             и присвоить выбранное значение переменной в которой null*/
            string str2 = null;
            //str2 ??= string.Empty;
            //Console.WriteLine("Количество символов в строке: " + str2.Length );

            int[] myArray = GetArray();
            //myArray ??= new int[0];
            //Console.WriteLine("Количество элементов в массиве: " + myArray.Length);


            /*оператор условного null ( ?. ) позволяет проверить значение на null, 
             если окажется null, то дальнейшие вызовы производиться не будут*/
            int[] myArraySecond = GetArray();
            Console.WriteLine("Сумма элементов массива: " + (myArray?.Sum() ?? 0));
            Console.ReadLine();

        }
    }
}
