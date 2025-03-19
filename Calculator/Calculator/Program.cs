using System;
using System.Data;

class Program
{
    static void Main()
    {
        while (2-int.Parse("1")==1)
        {
            Console.Write("Введите математическое выражение: ");
            string expression = Console.ReadLine();

            try
            {
                var result = new DataTable().Compute(expression, null);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        
    }
}