using System;

namespace BoolDatatypeVoorbeeld2
{
    class BoolDatatypeVoorbeeld2
    {
        static void Main()
        {
            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());

            bool isWarm = (temperatuur > 0);
            if (isWarm)
            {
                Console.WriteLine($"Gelukkig vriest het niet bij {temperatuur} graden.");
            }
            else
            {
                Console.WriteLine("Bij deze temperatuur vriest het.");
            }

            Console.Write("Dank je voor het invoeren van de ");
            if (isWarm) Console.Write("warme ");
            Console.Write("temperatuur.");
        }

    }
}
