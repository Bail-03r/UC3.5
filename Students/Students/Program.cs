using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("сколько студентов: ");
        int students = int.Parse(Console.ReadLine());
        int[] ocenki = new int[students];
        for (int i = 0; i < students; i++)
        {
            Console.Write($"оценка студента({i + 1}): ");
            ocenki[i] = int.Parse(Console.ReadLine());

            if (ocenki[i] < 1 || ocenki[i] > 5)
            {
                Console.WriteLine("оценка от 1 др 5");
                i--;

            }

        }
        Console.WriteLine();
        double middle = ocenki.Average();
        int pass = ocenki.Count(g => g > 4);
        int min = ocenki.Min();
        int max = ocenki.Max();

        Console.WriteLine($"средний балл > {middle:F2}");
        Console.WriteLine($"количество сдавших > {pass}");
        Console.WriteLine($"минимальная оценка > {min}");
        Console.WriteLine($"максимальная оценка > {max}");
    }
}