using System;

namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
        Restart:
            Random slump = new Random();
            int GissatTal = 0;
            int AntalFörsök = 0;
            int slumpTal = slump.Next(1, 101);
            while (GissatTal != slumpTal)
            {
                Console.WriteLine("Gissa på ett tal mellan 1 och 100");
                GissatTal = int.Parse(Console.ReadLine());
                AntalFörsök++;

                if (GissatTal < 1 || GissatTal > 100)
                {
                    Console.WriteLine("Du måste gissa på ett tal som är mellan 1 och 100.");
                }

                if (GissatTal > slumpTal && !(GissatTal > 100))
                {
                    Console.WriteLine("Fel gissat!");
                    Console.WriteLine("Slumptalet är lägre än vad du har gissat.");
                }

                if (GissatTal < slumpTal && !(GissatTal < 1))
                {
                    Console.WriteLine("Fel gissat!");
                    Console.WriteLine("Slumptalet är högre än vad du har gissat.");
                }

                if (GissatTal == slumpTal)
                {
                    Console.WriteLine("Rätt gissat!");
                    Console.WriteLine("Det tog dig " + AntalFörsök + " gånger att gissa!");
                    goto Restart;
                }
            }
        }
    }

}