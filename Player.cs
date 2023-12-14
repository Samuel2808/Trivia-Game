using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Game
{
    internal class Player
    {
        public string Name;
        public int Score; 

        public Player(string PlayerName) 
        { 
        Name = PlayerName;
            Score = 0;
        }
    }
}
