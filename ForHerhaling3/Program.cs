using System;

namespace ForHerhaling3
{
    class Program
    {
        static void Main()
        {
            for (int jaar = 1998; jaar >= 1990; jaar -= 2)
            {
                Console.WriteLine(jaar);
            }
            // jaar is buiten de for niet meer bruikbaar
        }

    }
}
