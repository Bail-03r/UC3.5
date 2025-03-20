using System;
using System.Threading;

class Program
{

    static void Main()
    {
        string[] actions = { "Прыгать", "обнимать случайного человека", "танцевать в присядку", "петь", "смотреть на случайного человека" };

        Random random = new Random();
        string randomAction = actions[random.Next(actions.Length)];

        int timeLimitInSeconds = 60;

        Console.WriteLine($"задание: {randomAction}");
        Console.WriteLine($"у вас есть 1 минута готовьтесь...");
        Thread.Sleep(3000);
        for (int i = timeLimitInSeconds; i >= 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"ваше задание: {randomAction} в течении времени");
            Console.WriteLine($"Осталось времени: {i} секунд");
            Thread.Sleep(1000);
        }

        Console.WriteLine("время вышло");
    }
}