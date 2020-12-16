using System;

namespace Enemies
{
    /// <summary> The representation of an empty class </summary>
    class Zombie
    {
        int health;
        string name = "(No name)";

        /// <summary> Constructor's methods for name of Zombie</summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

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

        public override string ToString()
        {
            return string.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}
