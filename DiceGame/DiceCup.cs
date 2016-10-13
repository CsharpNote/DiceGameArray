using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGameArray
{
    class DiceCup
    {
        Die[] terninger = new Die[5];

        private Die die1;
        private Die die2;
        private Die die3;

        public DiceCup()
        {
            // VERY IMPORTANT! When we have instance fields of a class type,
            // we MUST remember to create actual objects in the constructor,
            // that the instance fields can then point to.
            die1 = new Die(10);
            die2 = new Die(4);
            die3 = new Die(20);

        }

        public DiceCup(int [] terninger )
        {

        }

        /// <summary>
        /// Ruller alle terningerne i bægeret
        /// </summary>
        public void RollAllDiceInCup()
        {
            die1.RollDie();
            die2.RollDie();
            die3.RollDie();
        }


        // You must create a method with the below header:
        /// <summary>
        /// returnerer værdierer fra de tre terninger
        /// </summary>
        /// <returns></returns>
         public int GetTotalValue()
        {
            return die1.GetValue() + die2.GetValue() + die3.GetValue();
        }

        // You must create a method with the below header:
         public bool IsTotalValueLargerThan(int value)
        {
            int terningeværdi;
            bool checker;
            terningeværdi = GetTotalValue();

            checker = terningeværdi > value;

            return checker;

        }


    }
}
