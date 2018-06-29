using System;

namespace Slug_Fest__basics_
{
    /// <summary>
    /// Basic structure for every attack.
    /// </summary>
    public abstract class Attack : Values
    {
        //Attack name.
        public string moveName;
        //Attack target.
        public string target;
        //Where the attack is coming from.
        public string direction;
        //How many seconds the attack will take to complete.
        public double hitLength;
        //How many hitpoints this attack will do.
        public int damage;


        //The animation of the attack.
        public void Animation()
        {
            Console.Write(moveName);
        }

        //What this attack will hit.
        public void Target()
        {
            Console.WriteLine(" to {0} from {1}. {2} Damage done", target, direction, damage);
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
            target = Head();
            direction = Front();
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
            target = Head();
            direction = Front();
            hitLength = 0.8;
            damage = 2;
        }
    }

    /// <summary>
    /// Hook attack base.
    /// </summary>
    public class Hook : Attack
    {
        public Hook(string direction)
        {
            moveName = direction + " hook";
            target = Head();
            this.direction = direction;
            hitLength = 1.3;
            damage = 3;
        }
    }
}