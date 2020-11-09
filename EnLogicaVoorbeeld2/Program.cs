using System;

namespace EnLogicaVoorbeeld2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());

            if (temperatuur < 30 && temperatuur >= 15)
            {
                Console.WriteLine("Het is aangenaam warm.");
            }
        }

    }
}
