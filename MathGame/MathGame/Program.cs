using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int timeLimitInSeconds = 30;

        Console.WriteLine($"у тебя есть {timeLimitInSeconds} секунд чтобы решить как можно больше мат. примеров нажми enter xnj,s начать");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(timeLimitInSeconds);

        int correct = 0;
        int total = 0;

        while (DateTime.Now < endTime)
        {
            int one = random.Next(1, 100);
            int two = random.Next(1, 100);
            string[] operators = { "+", "-", "*" };
            string op = operators[random.Next(operators.Length)];

            Console.Write($"Сколько будет {one} {op} {two}? Ваш ответ: ");
            string input = Console.ReadLine();

            int anwser = 0;
            switch (op)
            {
                case "+":
                    anwser = one + two;
                    break;
                case "-":
                    anwser = one - two;
                    break;
                case "*":
                    anwser = one * two;
                    break;
            }

            if (int.TryParse(input, out int otvet) && otvet == anwser)
            {
                Console.WriteLine("правильно");
                correct++;
            }
            else
            {
                Console.WriteLine($"неправильно ответ: {anwser}");
            }

            total++;
            Console.WriteLine();
        }

        Console.WriteLine($"время вышло\nты решил {correct} из {total} примеров правильно");
        Console.Write("твой ранг: ");
        if (correct < 3)
        {
            Console.WriteLine("Пупс");
        } else if (correct < 6)
        {
            Console.WriteLine("Лох");
        } else if (correct < 9)
        {
            Console.WriteLine("Типо умный");
        } else if (correct >9)
        {
            Console.WriteLine("Чётырёхглазый");
        }
    }
}