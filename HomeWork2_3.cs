using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons1.Lesson_2
{
    class HomeWork2_3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("Введенное число четное");

            else
                Console.WriteLine("Введенное число нечетное");

        }
    }
}
