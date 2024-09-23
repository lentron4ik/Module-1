using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            string reversed = ReverseString(input);

            Console.WriteLine($"Строка в обратном порядке: {reversed}");
        }

        // Метод для разворота строки
        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray(); // Преобразование строки в массив символов
            Array.Reverse(charArray);           // Переворачиваем массив символов
            return new string(charArray);       // Преобразование массива символов обратно в строку
        }
    }
}
