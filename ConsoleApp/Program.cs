/*Костев Н.г.
 Написать программу «Анкета».
 Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
 В результате вся информация выводится в одну строчку:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c, d, e;
            Console.WriteLine("Введите ваше фамилию:");
            a = Console.ReadLine();
            Console.WriteLine("Введите ваше имя:");
            b = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            c = Console.ReadLine();
            Console.WriteLine("Веедите ваш рост:");
            d = Console.ReadLine();
            Console.WriteLine("Веедите ваш вес:");
            e = Console.ReadLine();
            Console.WriteLine($"{a} {b} возраст:{c} рост:{d} вес:{e}");
            Console.ReadLine();
        }
    }
}
