using System;

namespace ExclusieveOfVoorbeeld
{
    class ExclusieveOfVoorbeeld
    {
        static void Main()
        {
            string kaart1 = "Ruiten acht";
            string kaart2 = "Schoppen heer";

            string troef = "Schoppen";

            bool kaart1IsTroefkaart = kaart1.StartsWith(troef);
            bool kaart2IsTroefkaart = kaart2.StartsWith(troef);

            if (kaart1IsTroefkaart ^ kaart2IsTroefkaart)
            {                          
                string kaart = kaart1IsTroefkaart ? kaart1 : kaart2;//if (kaart1IsTroefkaart) kaart = kaart1; else kaart = kaart2;
                Console.Write($"{kaart} haalt de slag.");
            }
            else Console.Write("Vergelijk op waarde...");
        }

    }
}
