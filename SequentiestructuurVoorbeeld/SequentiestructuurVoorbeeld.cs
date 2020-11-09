using System;

namespace SequentiestructuurVoorbeeld
{
    class SequentiestructuurVoorbeeld
    {
        static void Main()
        {

            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());

            if (temperatuur <= 0)
            {
                Console.WriteLine("Bij deze temperatuur vriest het.");
            }

            Console.Write("Dank je voor het invoeren van de temperatuur.");

        }
    }
}
