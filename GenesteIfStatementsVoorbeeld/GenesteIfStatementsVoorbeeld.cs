using System;

namespace GenesteIfStatementsVoorbeeld
{
    class GenesteIfStatementsVoorbeeld
    {
        static void Main()
        {
            Console.Write("Temperatuur?: ");

            int temperatuur;
            if (int.TryParse(Console.ReadLine(), out temperatuur))
            {
                if (temperatuur <= 0)
                {
                    Console.WriteLine("Bij deze temperatuur vriest het.");
                }
                else
                {
                    Console.WriteLine($"Gelukkig vriest het niet bij {temperatuur} graden.");
                }
            }
            else
            {
                Console.Write("Gelieve een geheel getal in te voeren.");
            }
        }
    }

}
