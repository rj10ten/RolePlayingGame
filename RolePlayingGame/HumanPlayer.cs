using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class HumanPlayer : ICreatures, IPlayer
    {
        private const string Choose_Class_Text = "Please choose your starter class:";
        private const string Class_List = "1. Monk, 2. Warrior, 3. Mage, 4. Rogue, 5. Priest, 6. Paladin";

        public string Name { get; set; }
        public int Level { get; set; }
        public string ClassType { get; set; }
        public int ClassLevel { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }

        public void PrintStats()
        {
            Console.WriteLine("Your level is: " + Level + ".");
            Console.WriteLine("Your class is: " + ClassType 
                + " and it's level is: " + ClassLevel + ".");
            Console.WriteLine("Your current health is: " + CurrentHealth
                + ". Your max health is: " + MaxHealth + ".");
        }

        // Change this horrendous if tree into a switch
        public void ChooseClass()
        {
            // Class selection
            Console.WriteLine(Choose_Class_Text);
            Console.WriteLine(Class_List);
            string userClassChoice = Console.ReadLine();

            switch (int.Parse(userClassChoice))
            {
                case 1:
                    ClassType = "Monk";
                    break;

                case 2:
                    ClassType = "Warrior";
                    break;

                case 3:
                    ClassType = "Mage";
                    break;

                case 4:
                    ClassType = "Rogue";
                    break;

                case 5:
                    ClassType = "Priest";
                    break;

                case 6:
                    ClassType = "Paladin";
                    break;
            }
        }

        public void ReportChosenClass()
        {
            Console.WriteLine("You have chosen " + ClassType + " as your class.");
        }

        // Figure out how to assign new ClassType and have ClassLevel be stored for previous class
        public void ChangeClass()
        {
            Console.WriteLine("Would you like to change your class or stay with your current selection?" +
                " Any levels gained in a class will remain and you can keep previously learned abilities.");
            Console.WriteLine(" 1. Change Class, 2. Stick with my current class.");

            string changeClass = Console.ReadLine();

            if (int.Parse(changeClass) == 1)
            {
                // This overrides the previous class, need to add to an array perhaps
                // ChooseClass();

                // Class selection
                Console.WriteLine("Please choose a new class from the list:");
                Console.WriteLine(Class_List);
                string newClass = Console.ReadLine();

                switch (int.Parse(newClass))
                {
                    case 1:
                        ClassType = ClassType + ", " + "Monk";
                        break;

                    case 2:
                        ClassType = ClassType + ", " + "Warrior";
                        break;

                    case 3:
                        ClassType = ClassType + ", " + "Mage";
                        break;

                    case 4:
                        ClassType = ClassType + ", " + "Rogue";
                        break;

                    case 5:
                        ClassType = ClassType + ", " + "Priest";
                        break;

                    case 6:
                        ClassType = ClassType + ", " + "Paladin";
                        break;
                }

                ReportChosenClass();
            }
            else
            {
                Console.WriteLine("You have not chosen a new class. You are still a " + ClassType + ".");
            }
        }
    }
}
