using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInvoerHerhalen
{
    class Program2
    {
        static void Main()
        {
            int afstandInMeter;
            bool invoerOk;
            do
            {
                Console.Write("Afstand in meter?: ");
                invoerOk = int.TryParse(Console.ReadLine(), out afstandInMeter);
                if (!invoerOk) Console.WriteLine("Gelieve een geheel getal in te voeren!");
            } while (!invoerOk);

            Console.WriteLine($"In cm is dit: {afstandInMeter * 100}");

        }
    }

}
