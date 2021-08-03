/*Костев Н.г.
  Ввести вес и рост человека.
  Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, h, i;
            {
            Console.WriteLine("Введите свой рост:");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой вес:");
            m = double.Parse(Console.ReadLine());
                h = h / 100;
                i = m / (h * h);
                Console.WriteLine($"ИМТ={i}");
            Console.ReadLine();
            }
        }
    }
}
