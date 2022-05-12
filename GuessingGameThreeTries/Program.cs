using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis mängu võidab arvuti;
            //programm genereerib juhuslikku numbrit ühe korra;

            Random rnd = new Random();
            int i = 0;
            Console.WriteLine("Arva ära, mis number tuleb vahemikus 1-10?");
            int cpuRandomNumber = rnd.Next(1, 11);
            while (i < 3)
            {                
                int userRandomNumber = Convert.ToInt32(Console.ReadLine());         
                
                if (userRandomNumber == cpuRandomNumber)
                {
                    Console.WriteLine($"Õige. Arvasid ära. Arvuti poolt genereeritud number oli: {cpuRandomNumber}");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Sinu vastus on vale. Proovi veel {3 - i} korda");                    

                }
            }
            Console.WriteLine($"Arvuti poolt genereeritud number oli: {cpuRandomNumber}");







        }
    }
}
