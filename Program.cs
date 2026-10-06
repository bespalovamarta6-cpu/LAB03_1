namespace LAB03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите превое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма: {a + b}");
            Console.WriteLine($"Разность: {a - b}");
            Console.WriteLine($"Произведение: {a * b}");
            double average = (double)(a + b) / 2;
            Console.WriteLine($"Среднее арифметическое: {average}");

        }
    }
}
