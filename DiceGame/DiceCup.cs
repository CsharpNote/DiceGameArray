using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class DiceCup
    {
        private Die die1red;
        private Die die2;
        private Die die1000;

        public DiceCup()
        {
            // VERY IMPORTANT! When we have instance fields of a class type,
            // we MUST remember to create actual objects in the constructor,
            // that the instance fields can then point to.
            die1red = new Die(10);
            die2 = new Die(4);
            die1000 = new Die(20);

        }
        /// <summary>
        /// Ruller alle terningerne i bægeret
        /// </summary>
        public void RollAllDiceInCup()
        {
            //die1.RollDie();
            //die2.RollDie();
            RollTwoDice();
            die1000.RollDie();
        }

        public void RollTwoDice()
        {
            die1red.RollDie();
            die2.RollDie();
        }
        /// <summary>
        /// ruller den røde terning
        /// </summary>
        public void RollRedDie()
        {
            die1red.RollDie();

        }


        // You must create a method with the below header:
        /// <summary>
        /// returnerer værdierer fra de tre terninger
        /// </summary>
        /// <returns></returns>
         public int GetTotalValue()
        {
            return die1red.GetValue() + die2.GetValue() + die1000.GetValue();
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
