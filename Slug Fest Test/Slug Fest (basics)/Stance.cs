namespace Slug_Fest__basics_
{
    /// <summary>
    /// Basic structure for all stances.
    /// </summary>
    public abstract class Stance
    {
        public Attack light;
        public Attack heavy;
        public Attack leftHook;
        public Attack rightHook;

        public void lightAttack()
        {
            light.Animation();
            light.Target();
        }
        public void HeavyAttack()
        {
            heavy.Animation();
            heavy.Target();
        }
        public void LeftHookAttack()
        {
            leftHook.Animation();
            leftHook.Target();
        }
        public void RightHookAttack()
        {
            rightHook.Animation();
            rightHook.Target();
        }

    }

    /// <summary>
    /// Player's normal upright stance.
    /// </summary>
    public class Normal : Stance
    {
        public Normal()
        {
            light = new Jab();
            heavy = new Cross();
            leftHook = new Hook("left hook");
            rightHook = new Hook("right hook");
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
            heavy = new Cross();
            leftHook = new Hook("Rip") { target = "ribs" };
            rightHook = new Hook("uppercut") { target = "chest" };
        }
    }

    /// <summary>
    /// Player's right leaning stance.
    /// </summary>
    public class LeanRight : Lean
    {
        public LeanRight()
        {

        }
    }

    /// <summary>
    /// Player's left leaning stance
    /// </summary>
    public class LeanLeft : Lean
    {
        public LeanLeft()
        {

        }
    }
}