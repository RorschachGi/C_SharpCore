using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson5_For
{
    /*
     * Цикл for
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            for(int i =0; i < limit; i++)
            {
                Console.WriteLine(i);
            }

            //С несколькими условиями и счетчиками
            for(int i = 0, j = 5; i < 10 && j < 12; i++, j++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }



            // цикл for в обратном порядке
            for(int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            //Ключевые слова break ( прерываение цикла ) и continue ( пропустить итерацию )
            for(int i = 0; i < 100; i++)
            {
                string msg = Console.ReadLine();

                if (msg == "exit")
                {
                    break;
                }
            }


            for(int i = 0; i < 4; i++)
            {
                if(i == 2)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

        }
    }
}
