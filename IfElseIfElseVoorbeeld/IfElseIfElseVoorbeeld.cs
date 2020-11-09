using System;

namespace IfElseIfElseVoorbeeld
{
    class IfElseIfElseVoorbeeld
    {
        static void Main()
        {
            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());

            if (temperatuur >= 30)
            {
                Console.WriteLine("Het is erg warm.");
            }
            else if (temperatuur >= 15)
            {
                Console.WriteLine("Het is aangenaam warm.");
            }
            else if (temperatuur >= 5)
            {
                Console.WriteLine("Het is aan de frisse kant.");
            }
            else
            {
                Console.WriteLine("Je mag gerust stellen dat het koud is.");
            }
        }

    }
}
