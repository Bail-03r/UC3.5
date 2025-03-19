using System;

class Program
{
    static void Main()
    {
        Console.Write("высота: ");
        double metri = double.Parse(Console.ReadLine());
        Console.Write("интервал: ");
        double wait = double.Parse(Console.ReadLine());

        const double g = 9.81; double time = 0;

        while (metri > 0)
        {
            metri = metri - 0.5 * g * Math.Pow(wait, 2);
            if (metri <= 0)
            {
                Console.WriteLine($"{time + wait:F2} секунд шар упал и лопнул"); break;
            }
            time += wait; Console.WriteLine($"{time:F2} секунд <|> Высота: {metri:F2}");
        }
    }
}