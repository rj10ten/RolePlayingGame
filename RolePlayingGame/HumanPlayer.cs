using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class HumanPlayer : ICreatures, IPlayer
    {

        public string name;
        public int level;
        public string classType;
        public int classLevel;
        public int maxHealth;
        public int currentHealth;

        public void PrintStats()
        {
            Console.WriteLine("Your level is: " + level + ".");
            Console.WriteLine("Your class is: " + classType 
                + " and it's level is: " + classLevel + ".");
            Console.WriteLine("Your current health is: " + currentHealth
                + ". Your max health is: " + maxHealth + ".");
        }

        public void ChooseClass(String userClassChoice)
        {
            if (int.Parse(userClassChoice) == 1)
            {
                ClassType = "Monk";
            }

            if (int.Parse(userClassChoice) == 2)
            {
                ClassType = "Warrior";
            }

            if (int.Parse(userClassChoice) == 3)
            {
                ClassType = "Mage";
            }

            if (int.Parse(userClassChoice) == 4)
            {
                ClassType = "Rogue";
            }

            if (int.Parse(userClassChoice) == 5)
            {
                ClassType = "Priest";
            }

            if (int.Parse(userClassChoice) == 6)
            {
                ClassType = "Paladin";
            }
        }

        public void ReportChosenClass()
        {
            Console.WriteLine("You have chosen " + classType + " as your class.");
        }

        public string Name { get => name; set => name = value; }

        public int Level { get => level; set => level = value; }

        public string ClassType { get => classType; set => classType = value; }

        public int ClassLevel { get => classLevel; set => classLevel = value; }

        public int MaxHealth { get => maxHealth; set => maxHealth = value; }

        public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    }
}
