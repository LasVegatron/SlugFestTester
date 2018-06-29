

using System;

namespace Slug_Fest__basics_
{
    /// <summary>
    /// A list of body parts being blocked.
    /// </summary>
    public abstract class Body : Values
    {
        //True means blocked
        /// <summary>
        /// Is front being blocked?
        /// </summary>
        public bool front = false;
        /// <summary>
        /// Is left side being blocked.
        /// </summary>
        public bool left = false;
        /// <summary>
        /// Is right side being blocked?
        /// </summary>
        public bool right = false;

        public double damage = 1;

        public double Damage()
        {
            return damage;
        }

        /// <summary>
        /// Checks if inputed direction will hit a vulnerable or a block.
        /// </summary>
        /// <param name="from"></param>
        public void Check(string from)
        {
            CheckForDamage(from, Front());
            CheckForDamage(from, Left());
            CheckForDamage(from, Right());
        }

        /// <summary>
        /// Checks if inputed direction equals inputed location.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        private void CheckForDamage(string from, string to)
        {
            if (from == to)
            {
                //Hit successful.
                Console.WriteLine("Hit");
            }
            //Part is blocked.
            else
            {
                //Hit connected but blocked.
                Console.WriteLine("Blocked");
            }
        }
    }

    /// <summary>
    /// A list of parts the head will be blocked and/or able to dodge.
    /// </summary>
    public class Head : Body
    {
        //There needs to be 2 conditions for the head. One that states whether or not that side is blocked and another for
        //if that side won't get hit (i.e. in the event of a slip). An attack must be thrown in the corresponidng direction for an attack.
        /// <summary>
        /// Will an attack to the front of the face miss target?
        /// </summary>
        public bool frontSlip = false;
        /// <summary>
        /// Will an attack to the left side of the face miss target?
        /// </summary>
        public bool leftSlip = false;
        /// <summary>
        /// Will an attack to the right side of the face miss target?
        /// </summary>
        public bool rightSlip = false;

        //TODO: make a damage decider for head class.

        public bool SlipFront()
        {
            return frontSlip;
        }

        public bool SlipLeft()
        {
            return leftSlip;
        }

        public bool SlipRight()
        {
            return rightSlip;
        }

        public void CheckForDamage(string from)
        {

        }
    }
}