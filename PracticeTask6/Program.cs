using System;

namespace PracticeTask6
{
    public class Program
    {
        public static double a1; // первый элемент последовательности
        public static double a2; // второй элемент последовательности
        public static double a3; // третий эоемент последовательности
        public static uint N; // количество элементов последовательности
        public static uint M; // искомые числа, большие L
        public static double L; // условие для элементов последовательности M

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в приложение по работе с рекурсивным методом вычисления элементов последовательности!");

            // Ввод 3 начальных элементов последовательности
            Console.WriteLine("\nВведите 3 начальных элемента последовательности");
            Console.WriteLine("Введите 1 элемент последовательности");
            a1 = InputDouble();
            Console.WriteLine("\nВведите 2 элемент последовательности");
            a2 = InputDouble();
            Console.WriteLine("\nВведите 3 элемент последовательности");
            a3 = InputDouble();

            // Ввод чисел N, M, L
            Console.WriteLine("\nВведите N - количество элементов последовательности");
            N = InputUint(1, 100);
            Console.WriteLine("\nВведите M - количество элементов, которые больше числа L");
            M = InputUint(1, N);
            Console.WriteLine("\nВведите L - число, больше которого должны быть элементы N");
            L = InputDouble();

            // Определим, есть ли искомые числа M
            Console.WriteLine("\nНайдем элементы M, большие числа L");
            bool check = FindNumbersM();
            if (check)
            {
                // Печать M чисел, больших L
                Console.WriteLine("Элементы M, большие числа L, найдены");
                Console.WriteLine("Печать элементов M");
                PrintNumbersM();
            }
            else
            {
                // Печать N чисел
                Console.WriteLine("Элементы M, большие числа L, не найдены");
                Console.WriteLine("Печать элементов N");
                PrintNumbersN();
            }

            Console.WriteLine("\nЗавершение работы в приложении по работе с рекурсивным методом вычисления элементов последовательности");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }

        // Рекурсивная функция определения числа члена последовательности
        public static double A(int k)
        {
            if (k == 1) return a1;
            if (k == 2) return a2;
            if (k == 3) return a3;
            return (7 / 3 * A(k - 1) + A(k - 2)) / 2 * A(k - 3);
        }

        // Вывод чисел N
        private static void PrintNumbersN()
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(A(i));
            }
            Console.WriteLine();
        }

        // Поиск чисел M
        public static bool FindNumbersM()
        {
            int count = 0;
            for (int i = 1; i <= N; i++)
            {
                if (A(i) > L) count++;
                if (count == M) return true;
            }
            return false;
        }

        // Вывод чисел M
        private static void PrintNumbersM()
        {
            for (int i = 1; i <= N; i++)
                if (A(i) > L) Console.WriteLine(A(i));
            Console.WriteLine();
        }

        // Ввод действительного числа
        private static double InputDouble()
        {
            double number;
            bool check;
            do
            {
                Console.Write("Ввод: ");
                check = double.TryParse(Console.ReadLine(), out number);
                if (!check) Console.WriteLine("Ошибка! Введите вещественное число");
            } while (!check);
            return number;
        }

        // Ввод целого положительного числа с ограничениями
        private static uint InputUint(uint min, uint max)
        {
            uint number;
            bool check;
            do
            {
                Console.Write("Ввод: ");
                check = uint.TryParse(Console.ReadLine(), out number) && number >= min && number <= max;
                if (!check) Console.WriteLine($"Ошибка! Введите число в пределах от {min} до {max} (включительно)");
            } while (!check);
            return number;
        }
    }
}
