using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLoto5LR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация генератора случайных чисел
            Random rnd = new Random();

            // Создание списка для хранения выигрышных чисел
            List<int> winningNumbers = new List<int>();

            // Создание списка для хранения количества выпавших чисел от 1 до 49
            int[] numberCount = new int[49];

            // Повторяем 100 раз
            for (int i = 1; i <= 100; i++)
            {
                // Создание списка для хранения 6 уникальных чисел
                List<int> numbers = new List<int>();

                // Генерация 6 уникальных чисел
                while (numbers.Count < 6)
                {
                    int number = rnd.Next(1, 50);
                    if (!numbers.Contains(number))
                    {
                        numbers.Add(number);
                    }
                }

                // Сортировка выигрышных чисел
                numbers.Sort();

                // Добавление выигрышных чисел в список
                winningNumbers.AddRange(numbers);

                // Увеличение счетчика для каждого выпавшего числа
                foreach (int number in numbers)
                {
                    numberCount[number - 1]++;
                }
            }

            // Вывод выигрышных первых 6 чисел
            Console.WriteLine("Выигрышные числа:");
            foreach (var numbers in winningNumbers.Take(6))
            {
                Console.WriteLine(string.Join(", ", numbers));
            }
            //foreach (int number in winningNumbers)
            //{
            //    Console.Write(number + " ");
            //}
            Console.WriteLine();

            // Вывод количества выпавших чисел от 1 до 49
            Console.WriteLine("Количество выпавших чисел от 1 до 49:");
            for (int i = 1; i <= 49; i++)
            {
                Console.WriteLine(i + ": " + numberCount[i - 1]);
            }

            Console.ReadKey();
        }
    }
}
