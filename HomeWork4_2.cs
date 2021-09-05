using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson_4.HomeWork_4
{
    class HomeWork4_2
    {
        static void Main(string[] args)
        {
            {
                string numbersWords = EnterNumbers();
                string[] words = numbersWords.Split(new char[] { ' ' });
                int sum = 0;
                foreach (string s in words)
                {
                    int el = Convert.ToInt32(s);
                    int[] abc = new int[] { el };
                    sum += el;
                }
                Console.WriteLine(sum);
            }
        }
        static string EnterNumbers()
        {
            Console.WriteLine("Введите через пробел числа, кторые хотите сложить:");
            return Console.ReadLine();
        }

    }
}


