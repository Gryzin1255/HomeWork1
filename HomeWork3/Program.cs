/*Костев Н.Г.
 Написать программу обмена значениями двух переменных типа int без использования вспомогательных методо
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string [] args)
        {
            int a, b, tmp;
            Console.WriteLine("Введите a");
            a =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Введите b");
            b =Convert.ToInt32( Console.ReadLine());
            tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine("b равно {0}", b);
            Console.WriteLine("a равно {0}", a);
            Console.ReadLine();
        }
    }
}
