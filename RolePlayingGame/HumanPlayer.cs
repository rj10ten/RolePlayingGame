using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class HumanPlayer : ICreatures, IPlayer
    {
        public void PrintStats()
        {
            Console.WriteLine("Your level is: " + Level + ".");
            Console.WriteLine("Your class is: " + ClassType 
                + " and it's level is: " + ClassLevel + ".");
            Console.WriteLine("Your current health is: " + CurrentHealth
                + ". Your max health is: " + MaxHealth + ".");
        }

        // Change this horrendous if tree into a switch
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
            Console.WriteLine("You have chosen " + ClassType + " as your class.");
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string ClassType { get; set; }
        public int ClassLevel { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
    }
}
