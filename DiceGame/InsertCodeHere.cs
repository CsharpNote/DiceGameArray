using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGameArray
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            
            Console.WriteLine("Dicecup");
            DiceCup diceCup = new DiceCup();
            diceCup.RollAllDiceInCup();
            Console.WriteLine($"Samlet værdi {diceCup.GetTotalValue()}");

            int value1 = 10;
            bool resultat = diceCup.IsTotalValueLargerThan(value1);

            Console.WriteLine($"Er samlet terninge værdi større end {value1} resutat:{resultat}");




            Console.ReadLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}
