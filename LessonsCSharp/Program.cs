using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "54";

            int digit;

            bool result = int.TryParse(str, out digit);   
            if(result)
            {
                Console.WriteLine(digit);
            }
            else
            {
                Console.WriteLine("Конвертация не удалась");
            }

            Console.WriteLine("testGitHub");

        }
    }
}
