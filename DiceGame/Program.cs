using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, ongi võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja 

            Random rnd = new Random();

            //arvuti vise
            

            //kasutaja vise 
            

            int cpuScore = 0;
            int userScore = 0;
            
           
            for(int i = 0; i < 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                cpuScore = cpuScore + cpuRandom;
                userScore = userScore + userRandom;
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
              
            }
           
               
           
                if (cpuScore < userScore)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuScore > userScore)
                {
                    Console.WriteLine("Arvuti on mängu võitnud!");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }

                

        }
    }
}
