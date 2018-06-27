using System;

namespace Slug_Fest__basics_
{
    /// <summary>
    /// Player class.
    /// </summary>
    public class Fighter
    {
        private Normal normalStance = new Normal();
        private LeanLeft leftStance = new LeanLeft();
        private LeanRight rightStance = new LeanRight();

        private Stance current = new LeanLeft();

        public void Decision(char i)
        {
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

        public void Decision(string s)
        {
            if (s == "a")
            {
                current.LeftHookAttack();
            }
            else if (s == "s")
            {
                current.lightAttack();
            }
            else if (s == "d")
            {
                current.HeavyAttack();
            }
            else if (s == "f")
            {
                current.RightHookAttack();
            }
        }

        /// <summary>
        /// Test method to ensure attacks will be referenced.
        /// </summary>
        public void Combo()
        {
            current.lightAttack();
            current.HeavyAttack();
            current.LeftHookAttack();
            current.RightHookAttack();
        }
    }
}