using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    interface ICreatures
    {
        string Name { get; set; }
        
        int Level { get; set; }

        int MaxHealth { get; set; }

        int CurrentHealth { get; set; }
    }
}
