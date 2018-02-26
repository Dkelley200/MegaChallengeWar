using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Card
    {
        public string suit { get; set; }
        public string faceValue { get; set; }

        public int CardValue ()
        {
            int value = 0;

            switch (faceValue)
            {
                case "Ace": value = 14;
                    break;
                case "King": value = 13;
                    break;
                case "Queen": value = 12;
                    break;
                case "Jack": value = 11;
                    break;
                default: value = int.Parse(faceValue);
                    break;
                      }
            return value;
        }
        
    }
}