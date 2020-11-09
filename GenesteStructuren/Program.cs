using System;

namespace GenesteStructuren
{
    class Program
    {
        static void Main()
        {
            do
            {
                int getal;
                Console.Write("Geheel getal (min 2)?: ");
                if (int.TryParse(Console.ReadLine(), out getal) && getal >= 2)
                {
                    bool deelbaarDoor = false;
                    int deler = 2;
                    while (!deelbaarDoor && deler < getal)
                    {
                        deelbaarDoor = (getal % deler == 0);
                        deler = deler + 1;
                    }
                    if (deelbaarDoor)
                    {
                        Console.WriteLine($"{getal} is geen priemgetal.");
                    }
                    else
                    {
                        Console.WriteLine($"{getal} is een priemgetal.");
                    }
                }
                else
                {
                    Console.WriteLine("Dit is geen geheel getal (die minstens 2 is).");
                }
                Console.WriteLine();
            } while (true);

        }
    }
}
