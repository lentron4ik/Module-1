using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация генератора случайных чисел
            Random random = new Random();

            // массив из 15 случайных 
            int[] numbers = new int[15];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-100, 101); // Генерация числа от -100 до 100 включительно
            }

            Console.WriteLine("Сгенерированный массив чисел:");
            Console.WriteLine(string.Join(", ", numbers));

            // Находим все положительные числа
            var positiveNumbers = numbers.Where(n => n > 0).ToArray();

            if (positiveNumbers.Length > 0)
            {
                // Вычисляем среднее значение положительных чисел
                double average = positiveNumbers.Average();

                // Выводим результат
                Console.WriteLine($"Среднее значение положительных чисел: {average:F2}");
            }
            else
            {
                Console.WriteLine("В массиве нет положительных чисел.");
            }
        }
    }
}