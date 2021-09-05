using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson_4.HomeWork_4
{
    class HomeWork4_3
    {
        enum seasons { Winter, Spring, Summer, Autumn }

        public static void Main(string[] args)
        {
            static int EnterMonth()
            {
                Console.WriteLine("Введите порядковый номер месяца");
                int a = Convert.ToInt32(Console.ReadLine());
                return a;
            }

            static seasons OfMonth(int monthNumber)
            {
                switch ((monthNumber % 12) / 3)
                {
                    case 0:
                        return seasons.Winter;
                    case 1:
                        return seasons.Spring;
                    case 2:
                        return seasons.Summer;
                    default: return seasons.Autumn;
                }
            }

            static string Season(seasons s)
            {
                switch (s)
                {
                    case seasons.Winter:
                        return "Зима";
                    case seasons.Spring:
                        return "Весна";
                    case seasons.Summer:
                        return "Лето";
                    case seasons.Autumn:
                        return "Осень";
                    default:
                        return "";
                }
            }

            do
            {
                int mnth = EnterMonth();

                if (mnth <= 0 || mnth > 12)
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                else Console.WriteLine(Season(OfMonth(mnth)));
                Console.ReadKey();
            }
            while (true);
        }
    }
}
