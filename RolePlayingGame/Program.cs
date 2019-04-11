using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanPlayer player = new HumanPlayer();
            Game game = new Game(player);
            game.PlayGame();
        }
    }
}
