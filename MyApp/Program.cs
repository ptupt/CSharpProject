using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число x:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int x))
            {
                int y = 5 * x + 20;
                Console.WriteLine($"Результат: y = {y}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите целое число!");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}