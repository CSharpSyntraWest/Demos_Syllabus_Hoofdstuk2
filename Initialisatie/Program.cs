using System;

namespace Initialisatie
{
    class Program
    {
        static void Main()
        {
            int jaar = 1900;
            do
            {
                Console.WriteLine(jaar);
                jaar = jaar + 1;
            } while (jaar <= 1999);

            Console.ReadLine();
        }

    }
}
