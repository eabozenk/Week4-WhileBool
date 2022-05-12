using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //programm genereerib juhuslikku numbrit ühe korra;

            
            Random rnd = new Random();
            bool loopActive = true;

            Console.WriteLine("Arva ära, mis number tuleb vahemikus 1-10?");
            int cpuRandomNumber = rnd.Next(1, 11);
            while (loopActive)
            {
                int userRandomNumber = Convert.ToInt32(Console.ReadLine());                

                if (userRandomNumber == cpuRandomNumber)
                {
                    Console.WriteLine($"Õige. Arvasid ära. Arvuti poolt genereeritud number oli: {cpuRandomNumber}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Sinu vastus on vale. Proovi veel");
                }
            }
        }
    }
}