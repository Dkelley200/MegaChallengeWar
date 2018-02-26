using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> PlayerCard { get; set; }

        public Player()
            {
                PlayerCard = new List<Card>();
            }


    }
}