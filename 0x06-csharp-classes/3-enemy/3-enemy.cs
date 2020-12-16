using System;

namespace Enemies
{
    /// <summary> The representation of an empty class </summary>
    class Zombie
    {
        /// <summary> Represents the zombie's health </summary>
        public int health;

        /// <summary> Initializes a new instance of the <see cref="Zombie"/> class</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary> To initialize a new instance of the <see cref="Zombie"/> class </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
                health = value;
        }

         /// <summary> Returns the value of health's Zombie object</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
