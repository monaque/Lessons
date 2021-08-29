using System;


namespace Lessons1.Lesson_2
{
    class HomeWork2_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(((Months)a).ToString());
        }

        enum Months
        {
            Январь = 1,
            Февраль = 2,
            Март = 3,
            Апрель = 4,
            Май = 5,
            Июнь = 6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12,
        }
    }
}
