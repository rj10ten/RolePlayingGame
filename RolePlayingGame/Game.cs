using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class Game
    {

        public Game (HumanPlayer player)
        {
            this.player = player;
        }

        private const string IntroText = "Hello, would you like to play a game?";
        private const string IntroChoice = "1. Yes, 2. No";
        private const string ConfirmationText = "Great, we shall play a game now.";
        private const string ExitGameText = "Okay, I hope you play next time then.";
        private HumanPlayer player;

        public void PlayGame()
        {
            Game game = new Game(player);
            game.CreateGame();
            game.MakeStarterCharacter();
        }

        public void CreateGame()
        {

            Console.WriteLine(IntroText);
            Console.WriteLine(IntroChoice);

            int introChoice = int.Parse(Console.ReadLine());

            if (introChoice == 1) {
                Console.WriteLine(ConfirmationText);
            }
            else
            {
                Console.WriteLine(ExitGameText);
                Environment.Exit(2);
            }
        }

        public void MakeStarterCharacter()
        {
            ChooseCharacterName();
            ChooseCharacterClass();
            // This chooses a new class but overwrites the historical one without saving it
            ChooseAnotherClass();
            SetAndPrintDefaultStats();

            // Confirmation of character completion, add loop to allow recreation of character
            Console.WriteLine("Are you happy to procede with your character?");
            string characterConfirmation = Console.ReadLine();
        }

        private void SetAndPrintDefaultStats()
        {
            // This sets the default characters stats, add random stat generation later
            this.player.ClassLevel = 1;
            this.player.CurrentHealth = 10;
            this.player.MaxHealth = 10;
            this.player.Level = 1;

            // This prints the assigned stats
            this.player.PrintStats();
        }

        private void ChooseCharacterClass()
        {
            this.player.ChooseClass(userClassChoice);
            this.player.ReportChosenClass();
        }

        private void ChooseAnotherClass()
        {

            this.player.ChangeClass();
        }

        private void ChooseCharacterName()
        {
            // Name selection
            Console.WriteLine("Please choose a name for your character.");
            string userInput = Console.ReadLine();
            this.player.Name = userInput;
            Console.WriteLine("You have chosen the name: " + userInput);
        }
    }
}
