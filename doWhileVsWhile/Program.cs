using System;

namespace doWhileVsWhile
{
    class Program
    {
        static void Main()
        {
            int afstandInMeter;
            Console.Write("Afstand in meter?: ");
            bool invoerOk = int.TryParse(Console.ReadLine(), out afstandInMeter);
            while (!invoerOk)
            {
                Console.WriteLine("Gelieve een geheel getal in te voeren!");
                Console.Write("Afstand in meter?: ");
                invoerOk = int.TryParse(Console.ReadLine(), out afstandInMeter);
            }

            Console.WriteLine($"In cm is dit: {afstandInMeter * 100}");
        }

    }
}
