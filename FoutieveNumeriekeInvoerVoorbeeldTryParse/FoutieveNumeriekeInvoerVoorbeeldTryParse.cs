using System;

namespace FoutieveNumeriekeInvoerVoorbeeldTryParse
{
    class FoutieveNumeriekeInvoerVoorbeeldTryParse
    {
        static void Main()
        {
            Console.Write("Getal?: ");
            string ingevoerdeWaarde = Console.ReadLine();

            int getal;
            bool invoerOk = int.TryParse(ingevoerdeWaarde, out getal);
            if (invoerOk)
            {
                Console.Write($"Je hebt een waarde ingevoerd die als int waarde {getal} kan geïnterpreteerd worden.");
            }
            else
            {
                Console.Write("Gelieve een geheel getal in te voeren.");
            }
        }

    }
}
