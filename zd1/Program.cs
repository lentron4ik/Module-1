using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1
{
    internal class Program
    {
        // Метод для вычисления факториала
        static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факториал для отрицательных чисел не определен.");
            }
            if (n == 0 || n == 1) // если введено 1 или 0 возращается всегда 1 без доп.вычислений
            {
                return 1;
            }
            long result = 1;
            for (int i = 2; i <= n; i++) // На каждой итерации результат перемножается с текущим значением счетчика i.
            {
                result *= i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число для вычисления факториала:");
                int number = int.Parse(Console.ReadLine());

                long factorial = Factorial(number);

                Console.WriteLine($"Факториал числа {number} = {factorial}");
            }
            catch (FormatException)
            {
                Console.WriteLine("введите корректное число.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
