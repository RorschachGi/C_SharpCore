using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_WhileLesson
{
    /*
     * Цикд while и do while
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //while
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            while (count < limit)
            {
                Console.WriteLine(count);
                count++;
            }

            //do while cначала выполняет тело цикла, а затем проверяет условие 
            int countSecond = 0;
            do
            {
                countSecond++;
                Console.WriteLine(countSecond);
            } while (countSecond < 5);



            Console.ReadLine();
        }

       
    }
}
