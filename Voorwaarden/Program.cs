using System;

namespace Voorwaarden
{
    class Program
    {
        static void Main()
        {
            int jaar = 1990;
            do
            {
                Console.WriteLine(jaar);
                jaar = jaar + 1;
            } while (jaar <= 1999);

            Console.ReadLine();
        }

    }
}
