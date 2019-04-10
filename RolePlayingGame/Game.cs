using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class Game
    {

        private const string INTRO_TEXT = "Hello, would you like to play a game?";
        private const string INTRO_CHOICE = "1. Yes, 2. No";
        private const string YES_TO_GAME_TEXT = "Great, we shall play a game now.";
        private const string EXIT_GAME_TEXT = "Okay, I hope you play next time then.";

        public void CreateGame()
        {

            Console.WriteLine(INTRO_TEXT);
            Console.WriteLine(INTRO_CHOICE);

            int introChoice = int.Parse(Console.ReadLine());

            if (introChoice == 1) {
                Console.WriteLine(YES_TO_GAME_TEXT);
            } else
            {
                Console.WriteLine(EXIT_GAME_TEXT);
                Environment.Exit(0);
            }
        }

        public void PlayGame(HumanPlayer player)
        {
            CreateGame();
        }

    }
}
