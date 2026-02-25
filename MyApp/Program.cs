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
                int result = y * 2; // Увеличиваем в 2 раза
                Console.WriteLine($"Результат (увеличенный в 2 раза): {result}");
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