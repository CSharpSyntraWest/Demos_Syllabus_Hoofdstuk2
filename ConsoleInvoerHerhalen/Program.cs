using System;

namespace ConsoleInvoerHerhalen
{
    class Program
    {
        static void Main1()
        {
            int afstandInMeter;
            bool invoerOk;
            do
            {
                Console.Write("Afstand in meter?: ");
                invoerOk = int.TryParse(Console.ReadLine(), out afstandInMeter);
            } while (!invoerOk);

            Console.WriteLine($"In cm is dit: {afstandInMeter * 100}");
        }

    }
}
