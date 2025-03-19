using System;
using System.ComponentModel.Design;
using System.Diagnostics;

class Programm
{
    static int GetCard()
    {
        int[] Cards = Enumerable.Range(1, 11).ToArray();
        Random rd = new Random();
        int randomIndex = rd.Next(0, Cards.Length);
        int randomCard = Cards[randomIndex];
        return randomCard;
    }

    static void Main()
    {

        int Ryka = 0;
        int DealerRyka = 0;

        Ryka += GetCard();
        DealerRyka += GetCard();
        bool Stop = false;
        while (Stop==false)
        {

            if (Ryka <= 20)
            {
                Console.WriteLine($"На вашей руке {Ryka} у диллера на руке {DealerRyka} взять карту? hit/stand");
                string input = Console.ReadLine();
                if (input == "hit")
                {
                    Ryka += GetCard();
                } else if (input == "stand")
                {
                    while (DealerRyka < 21)
                    {
                        DealerRyka += GetCard();
                        if (DealerRyka>Ryka)
                        {
                            if (DealerRyka>21)
                            {
                                Console.WriteLine($"Диллер проиграл у него перебор({DealerRyka})");
                                Stop = true;
                            } else
                            {
                                Console.WriteLine($"Диллер Выйграл у него {DealerRyka}");
                                Stop = true;
                            }
                            
                            break;
                        }
                    }
                }

            } else if (Ryka==21) {
                Console.WriteLine("Вы выйграли у вас 21");
                break;
            } else
            {
                Console.WriteLine($"Ваша рука больше 21 ({Ryka}) диллер выйграл");
                break;
            }
            
        }
    }
}