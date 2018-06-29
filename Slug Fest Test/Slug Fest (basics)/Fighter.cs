using System;

namespace Slug_Fest__basics_
{
    /// <summary>
    /// Player class.
    /// </summary>
    public class Fighter
    {
        //list of stances
        private Normal normalStance = new Normal();
        private LeanLeft leftStance = new LeanLeft();
        private LeanRight rightStance = new LeanRight();

        //the current stance the player is in. ensures only one stance can be taken
        private Stance current = new LeanLeft();

        //TODO: allow for the fighter class to take in communicated attacks and return a message on whether or not a hit landed and how much damage.

        /// <summary>
        /// Used as a decision dial. Takes single input character as a command
        /// </summary>
        /// <param name="i"></param>
        public void Decision(char i)
        {
            //TODO: modify commands so that they may be communicated to a seperate fighter class.
            if (i == '8')
            {
                Console.WriteLine("regular stance");
                current = new Normal();
            }
            else if (i == '4')
            {
                Console.WriteLine("left stance");
                current = new LeanLeft();
            }
            else if (i == '6')
            {
                Console.WriteLine("right stance");
                current = new LeanRight();
            }
            else if (i == 'a')
            {
                current.LeftHookAttack();
            }
            else if (i == 's')
            {
                current.lightAttack();
            }
            else if (i == 'd')
            {
                current.HeavyAttack();
            }
            else if (i == 'f')
            {
                current.RightHookAttack();
            }
        }
    }
}