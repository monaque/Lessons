using System;


namespace Lessons1.Lesson_3
{
    class HomeWork3_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для переворачивания слов =) Введите любое слово:");
            string str = Console.ReadLine();
            Console.WriteLine("Наоборот:");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
    }
}
