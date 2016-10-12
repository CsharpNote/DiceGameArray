using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            //10 sidet terning
            Die minDie = new Die(10);
            minDie.RollDie();


            //Die dicetusindudenforkop = new Die(1000);
            //dicetusindudenforkop.RollDie();
            //Console.WriteLine($"the value of the dice is {dicetusindudenforkop.GetValue()}");

            //Die die87 = new Die(87);
            //die87.RollDie();
            //Console.WriteLine($"the value of the dice is {die87.GetValue()}");

            // The FIRST line of code should be BELOW this line
            //Die die1 = new Die();
            //Console.WriteLine($"the value of the dice is {die1.GetValue()}");
            //die1.RollDie();
            //Console.WriteLine($"the value of the dice is {die1.GetValue()}");
            //die1.RollDie();
            //Console.WriteLine($"the value of the dice is {die1.GetValue()}");
            //die1.RollDie();
            //Console.WriteLine($"the value of the dice is {die1.GetValue()}");
            //die1.RollDie();
            //Console.WriteLine($"the value of the dice is {die1.GetValue()}");

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
