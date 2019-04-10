using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class HumanPlayer : ICreatures, IClassType
    {
        public string name;
        public int level;
        public string classType;
        public int classLevel;
        public int maxHealth;
        public int currentHealth;

        public string Name { get => name; set => name = value; }

        public int Level { get => level; set => level = value; }

        public string ClassType { get => classType; set => classType = value; }

        public int ClassLevel { get => classLevel; set => classLevel = value; }

        public int MaxHealth { get => maxHealth; set => maxHealth = value; }

        public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    }
}
