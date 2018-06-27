using System;

namespace Slug_Fest__basics_
{
    /// <summary>
    /// Basic structure for every attack.
    /// </summary>
    public abstract class Attack
    {
        //attack name
        public string moveName;
        //attack target
        public string target;
        //how many seconds the attack will take to complete
        public double hitLength;
        //how many hitpoints this attack will do
        public int damage;

        //the animation of the attack
        public void Animation()
        {
            Console.Write(moveName);
        }

        //what this attack will hit
        public void Target()
        {
            Console.WriteLine(" to {0}. {1} Damage done", target, damage);
        }
    }

    /// <summary>
    /// Jab attack.
    /// </summary>
    public class Jab : Attack
    {
        public Jab()
        {
            moveName = "Jab";
            target = "head";
            hitLength = 0.5;
            damage = 1;
        }
    }

    /// <summary>
    /// Cross attack.
    /// </summary>
    public class Cross : Attack
    {
        public Cross()
        {
            moveName = "Cross";
            target = "head";
            hitLength = 0.8;
            damage = 2;
        }
    }

    /// <summary>
    /// Hook attack base.
    /// </summary>
    public class Hook : Attack
    {
        public Hook(string side)
        {
            moveName = side;
            target = "head";
            hitLength = 1;
            damage = 3;
        }
    }
}