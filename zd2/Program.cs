using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое целое число:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");
            int number2 = int.Parse(Console.ReadLine());

            // Вычисляем сумму
            int sum = number1 + number2;

            // Вывод суммы чисель
            Console.WriteLine($"Сумма чисел {number1} и {number2} = {sum}");
        }
    }
}
