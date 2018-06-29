namespace Slug_Fest__basics_
{
    /// <summary>
    /// Basic structure for all stances.
    /// </summary>
    public abstract class Stance : Values
    {
        //Set of defences per stance
        public Head head;
        public Body body;
        //Set of attacks per stance.
        public Attack light;
        public Attack heavy;
        public Attack leftHook;
        public Attack rightHook;

        /// <summary>
        /// Stance's light attack.
        /// </summary>
        public void lightAttack()
        {
            light.Animation();
            light.Target();
        }

        /// <summary>
        /// Stance's heavy attack.
        /// </summary>
        public void HeavyAttack()
        {
            heavy.Animation();
            heavy.Target();
        }

        /// <summary>
        /// Stance's left hook attack.
        /// </summary>
        public void LeftHookAttack()
        {
            leftHook.Animation();
            leftHook.Target();
        }

        /// <summary>
        /// Stance's right hook.
        /// </summary>
        public void RightHookAttack()
        {
            rightHook.Animation();
            rightHook.Target();
        }
        
        public void FindTarget(string attackThis, string from)
        {
            if (attackThis == Torso())
            {
                //find the direction it is coming from
                //check if the direction is blocked
            }
            else if (attackThis == Head())
            {
                //find the direction it is coming from
                //check if the direction is blocked or dodgeable
            }
        }
    }

    /// <summary>
    /// Player's normal upright stance.
    /// </summary>
    public class Normal : Stance
    {
        public Normal()
        {
            head = new Head() { front = true };
            light = new Jab();
            heavy = new Cross();
            leftHook = new Hook("left hook") { direction = Left() };
            rightHook = new Hook("right hook") { direction = Right() };
        }
    }

    /// <summary>
    /// Base class for leaning attacks.
    /// </summary>
    public abstract class Lean : Stance
    {
        public Lean()
        {
            light = new Jab();
            heavy = new Cross() { target = Torso() };
            leftHook = new Hook("uppercut") { target = Torso() };
            rightHook = new Hook("Rip") { target = Torso() };
        }
    }

    /// <summary>
    /// Player's right leaning stance.
    /// </summary>
    public class LeanRight : Lean
    {
        public LeanRight()
        {
            light = new Jab() { };
            heavy = new Cross() { target = Torso() };
            leftHook = new Hook("uppercut") { direction = Front() };
            rightHook = new Hook("Rip") { direction = Right() };
        }
    }

    /// <summary>
    /// Player's left leaning stance
    /// </summary>
    public class LeanLeft : Lean
    {
        public LeanLeft()
        {
            leftHook = new Hook("Rip") { target = Torso() };
            rightHook = new Hook("uppercut") { target = Torso() };
        }
    }
}