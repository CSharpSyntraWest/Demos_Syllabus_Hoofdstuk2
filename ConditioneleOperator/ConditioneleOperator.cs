using System;

namespace ConditioneleOperator
{
    class ConditioneleOperator
    {
        static void Main()
        {
            Console.Write("Getal?: ");
            int getal = int.Parse(Console.ReadLine());

            string getalInfo;

            //if (getal % 2 == 0) getalInfo = "even"; else getalInfo = "oneven";
            getalInfo = (getal % 2 == 0) ? "even" : "oneven";

            Console.Write($"Dit is een {getalInfo} getal.");
        }

    }
}
