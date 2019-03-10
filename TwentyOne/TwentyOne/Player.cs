using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }

        //public static game operator+ (game game, player player)
        //{ 
        //    game.players.add(player);
        //    return game;
        //}

        //public static game operator -(game game, player player)
        //{
        //    game.players.remove(player);
        //    return game;
        //}
        
    }
}
