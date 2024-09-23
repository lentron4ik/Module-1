using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd5
{
    internal class Program
    {
        // Метод для проверки, является ли число простым
        static bool IsPrime(int number)
        {
            // Отрицательные числа, 0 и 1 не являются простыми числами
            if (number <= 1)
                return false;

            // Проверяем делители числа от 2 до корня из числа
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false; // Если найден делитель, то число не простое
            }

            return true; // Если делителей нет, то число простое
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое число для проверки:");
                int number = int.Parse(Console.ReadLine());

                // Проверка является ли число простым
                if (IsPrime(number))
                {
                    Console.WriteLine($"Число {number} является простым.");
                }
                else
                {
                    Console.WriteLine($"Число {number} не является простым.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное целое число.");
            }
        }
    }
}

