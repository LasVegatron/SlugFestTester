namespace Slug_Fest__basics_
{
    public class Fighter
    {
        private Normal normalStance = new Normal();
        private LeanLeft leftStance = new LeanLeft();
        private LeanRight rightStance = new LeanRight();

        /// <summary>
        /// Tesst method to ensure attacks will be referenced.
        /// </summary>
        public void StandCombo()
        {
            normalStance.lightAttack();
            normalStance.HeavyAttack();
            normalStance.LeftHookAttack();
            normalStance.RightHookAttack();
        }
    }
}