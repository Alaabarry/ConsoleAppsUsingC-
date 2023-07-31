using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class TwentyOneGame : Game, IwalkAway
    {
        public override void Play() {

            throw new NotImplementedException();

        }
        public override void listPlayers()

        {
            Console.WriteLine("21 players ");
            base.listPlayers();
        }
        

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
