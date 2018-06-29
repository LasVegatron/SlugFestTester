namespace Slug_Fest__basics_
{
    /// <summary>
    /// Used to hold a set of values to avoid "magic values", ensuring that the only main strings used for targeting are the ones listed.
    /// </summary>
    public class Values
    {
        //List of two targets.
        private string head = "head";
        private string torso = "torso";

        //List of ways to target.
        private string front = "front";
        private string left = "left";
        private string right = "right";

        /// <summary>
        /// Displays head value without allowing editing.
        /// </summary>
        /// <returns></returns>
        public string Head()
        {
            return head;
        }

        /// <summary>
        /// Displays torso value without allowing editing.
        /// </summary>
        /// <returns></returns>
        public string Torso()
        {
            return torso;
        }

        /// <summary>
        /// Displays front value without allowing editing.
        /// </summary>
        /// <returns></returns>
        public string Front()
        {
            return front;
        }

        /// <summary>
        /// Displays left value without allowing editing.
        /// </summary>
        /// <returns></returns>
        public string Left()
        {
            return left;
        }

        /// <summary>
        /// Displays right value without allowing editing.
        /// </summary>
        /// <returns></returns>
        public string Right()
        {
            return right;
        }
    }
}