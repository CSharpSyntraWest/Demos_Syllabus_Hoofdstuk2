﻿using System;

namespace OfLogicaVoorbeeld1
{
    class OfLogicaVoorbeeld1
    {
        static void Main()
        {
            Console.Write("Toegang: 1=kind 2=gepensioneerde 3=volwassene ?: ");
            string soortPersoon = Console.ReadLine();

            string toegangsPrijs;
            if (soortPersoon == "1" || soortPersoon == "kind")
            {
                toegangsPrijs = "De toegang bedraagt 10EUR.";
            }
            else if (soortPersoon == "2" || soortPersoon == "gepensioneerd")
            {
                toegangsPrijs = "De toegang bedraagt 20EUR.";
            }
            else if (soortPersoon == "3" || soortPersoon == "volwassene")
            {
                toegangsPrijs = "De toegang bedraagt 30EUR.";
            }
            else
            {
                toegangsPrijs = "Gelieve een correct keuze te maken uit de aangeboden opties.";
            }
            Console.Write(toegangsPrijs);
        }

    }
}
