using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] Words = {"лада", "бревно", "человеконенавистничество", "таракан","хрюндель"};
        Random random = new Random();
        string RandomWord = Words[random.Next(Words.Length)];
        char[] TempGuess = new char[RandomWord.Length];
        List<string> Body = new List<string> {"левая рука", "правая рука","левая нога", "правая нога", "тело", "голова"};

        for (int i = 0; i < TempGuess.Length; i++)
        {
            TempGuess[i] = '_';
        }

        Console.WriteLine($"слово: {string.Join(" ", TempGuess)} ({RandomWord.Length} Букв)");

        while (Body.Count > 0)
        {
            Console.WriteLine($"\nтвои части тела: {string.Join(", ", Body)}\n");
            Console.Write("буква: ");
            char letter = Console.ReadLine()[0];

            bool letterFound = false;
            for (int i = 0; i < RandomWord.Length; i++)
            {
                if (RandomWord[i] == letter)
                {
                    TempGuess[i] = letter;
                    letterFound = true;
                }
            }

            if (!letterFound)
            {
                Console.WriteLine($"нету такой буквы от тебя отрезали {Body.First()}");
                Body.RemoveAt(0);
            }

            Console.WriteLine($"слово: {string.Join(" ", TempGuess)} ({RandomWord.Length} Букв)");

            if (string.Join("", TempGuess) == RandomWord)
            {
                Console.WriteLine("ты угадал слово");
                return;
            }
        }
        Console.WriteLine("от тебя отрубили все части тела ты умер");
    }
}