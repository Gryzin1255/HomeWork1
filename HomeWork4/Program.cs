/*Костев Н.г.
 Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 Сделать задание, только вывод организовать в центре экрана.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void PrintXY(int x, int y, string message)
        {
            Console.SetCursorPosition(x,y);
            Console.Write(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше фамилию:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите ваше имя:");
            string b = Console.ReadLine();
            Console.WriteLine("Веедите ваш город");
            string c = Console.ReadLine();
            PrintXY(55, 15, $"{a} {b} {c}");
            //Console.SetCursorPosition(55, 15);
            //Console.WriteLine($"{a} {b} {c}");
            Console.ReadLine();
        }
    }
}
