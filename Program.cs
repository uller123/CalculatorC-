using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Простейший калькулятор ===");
            Console.WriteLine("Добро пожаловать! Этот рабочий калькулятор готов к использованию.");
            Console.WriteLine();

            bool continueCalculating = true;

            while (continueCalculating)
            {
                try
                {
                    ShowMenu();
                    int choice = GetUserChoice();

                    if (choice == 8)
                    {
                        Console.WriteLine("Спасибо за использование калькулятора!");
                        continueCalculating = false;
                        continue;
                    }

                    PerformCalculation(choice);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }

                if (continueCalculating)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            Console.WriteLine("5. Возведение в степень (^)");
            Console.WriteLine("6. Квадратный корень (√)");
            Console.WriteLine("7. Процент от числа (%)");
            Console.WriteLine("8. Выход");
            Console.Write("Ваш выбор: ");
        }

        static int GetUserChoice()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 8)
            {
                return choice;
            }
            throw new ArgumentException("Неверный выбор. Пожалуйста, выберите число от 1 до 8.");
        }

        static void PerformCalculation(int choice)
        {
            double result = 0;

            switch (choice)
            {
                case 1: // Сложение
                    Console.Write("Введите первое число: ");
                    double a1 = GetNumber();
                    Console.Write("Введите второе число: ");
                    double b1 = GetNumber();
                    result = LogicCommands.Add(a1, b1);
                    Console.WriteLine($"Результат: {a1} + {b1} = {result}");
                    break;

                case 2: // Вычитание
                    Console.Write("Введите первое число: ");
                    double a2 = GetNumber();
                    Console.Write("Введите второе число: ");
                    double b2 = GetNumber();
                    result = LogicCommands.Subtract(a2, b2);
                    Console.WriteLine($"Результат: {a2} - {b2} = {result}");
                    break;

                case 3: // Умножение
                    Console.Write("Введите первое число: ");
                    double a3 = GetNumber();
                    Console.Write("Введите второе число: ");
                    double b3 = GetNumber();
                    result = LogicCommands.Multiply(a3, b3);
                    Console.WriteLine($"Результат: {a3} * {b3} = {result}");
                    break;

                case 4: // Деление
                    Console.Write("Введите делимое: ");
                    double a4 = GetNumber();
                    Console.Write("Введите делитель: ");
                    double b4 = GetNumber();
                    result = LogicCommands.Divide(a4, b4);
                    Console.WriteLine($"Результат: {a4} / {b4} = {result}");
                    break;

                case 5: // Степень
                    Console.Write("Введите основание: ");
                    double baseNum = GetNumber();
                    Console.Write("Введите степень: ");
                    double exponent = GetNumber();
                    result = LogicCommands.Power(baseNum, exponent);
                    Console.WriteLine($"Результат: {baseNum} ^ {exponent} = {result}");
                    break;

                case 6: // Корень
                    Console.Write("Введите число для извлечения корня: ");
                    double number = GetNumber();
                    result = LogicCommands.SquareRoot(number);
                    Console.WriteLine($"Результат: √{number} = {result}");
                    break;

                case 7: // Процент
                    Console.Write("Введите число: ");
                    double num = GetNumber();
                    Console.Write("Введите процент: ");
                    double percent = GetNumber();
                    result = LogicCommands.Percentage(num, percent);
                    Console.WriteLine($"Результат: {percent}% от {num} = {result}");
                    break;
            }
        }

        static double GetNumber()
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                return number;
            }
            throw new ArgumentException("Неверный формат числа. Пожалуйста, введите корректное число.");
        }
    }
}