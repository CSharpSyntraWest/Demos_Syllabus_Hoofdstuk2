using System;
using System.Collections.Generic;
using System.Text;

namespace BoolDatatypeVoorbeeld1
{
    class BoolDatatypeVoorbeeld1
    {
        static void Main()
        {
            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());

            bool hetVriest = (temperatuur <= 0);
            if (hetVriest)
            {
                Console.WriteLine("Bij deze temperatuur vriest het.");
            }
            else
            {
                Console.WriteLine($"Gelukkig vriest het niet bij {temperatuur} graden.");
            }

            Console.Write("Dank je voor het invoeren van de ");
            if (hetVriest == false) Console.Write("warme ");
            Console.Write("temperatuur.");
        }
    }

}
