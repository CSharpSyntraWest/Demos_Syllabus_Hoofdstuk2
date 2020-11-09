using System;

namespace EnLogicaVoorbeeld1
{
    class EnLogicaVoorbeeld1
    {
        static void Main()
        {
            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());

            if (temperatuur < 30)
            {
                if (temperatuur >= 15)
                {
                    Console.WriteLine("Het is aangenaam warm.");
                }
            }
        }

    }
}
