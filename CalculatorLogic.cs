namespace Calculator
{
    public class LogicCommands
    {
        // Метод для сложения
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Метод для вычитания
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Метод для умножения
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Метод для деления
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно!");
            }
            return a / b;
        }

        // Дополнительные методы для более сложных операций
        
        // Возведение в степень
        public static double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        // Квадратный корень
        public static double SquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Нельзя извлечь корень из отрицательного числа!");
            }
            return Math.Sqrt(number);
        }

        // Процент от числа
        public static double Percentage(double number, double percent)
        {
            return (number * percent) / 100;
        }
    }
}