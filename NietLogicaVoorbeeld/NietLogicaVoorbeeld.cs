using System;

namespace NietLogicaVoorbeeld
{
    class NietLogicaVoorbeeld
    {

        static void Main()
        {
            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());

            bool hetVriest = (temperatuur <= 0);
            if (hetVriest)  // of: (hetVriest == true)
            {
                Console.WriteLine("Bij deze temperatuur vriest het.");
            }

            Console.Write("Dank je voor het invoeren van de ");
            if (!hetVriest) // of: (hetVriest == false)
            {
                Console.Write("warme ");
            }
            Console.Write("temperatuur.");
        }
    }
}
