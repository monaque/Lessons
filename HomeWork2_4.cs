using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons1.Lesson_2
{
    class HomeWork2_4
    {
        public static void Main(string[] args)
        {
            string pos1 = "Морковь";
            double sum1 = 29.50;
            var date = DateTime.Now;
            string pos2 = "Сахар";
            double sum2 = 45.99;
            Console.WriteLine("Товары:       Стоимость:");
            Console.WriteLine($"{pos1}       {sum1}");
            Console.WriteLine($"{pos2}         {sum2}");
            Console.WriteLine(date);
            Console.WriteLine("Кассир: Головач Елена Михайловна.");
        }
    }
}
