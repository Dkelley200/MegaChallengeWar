using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace MegaChallengeWar
{
    public class Deck
    {
        private List<Card> _deck;
        //StringBuilder sb = new StringBuilder();
        //Random random = new Random();
        private Random _random;
        private StringBuilder _sb;

        public Deck()
        {

            _deck = new List<Card>();
            _random = new Random();
            _sb = new StringBuilder();

            string[] suit = new string[]
                {
               "Spades","Diamonds","Clubs","Hearts"
                };

            string[] faceValue = new string[]
                {
              "2","3","4","5", "6","7","8","9", "10","Jack","Queen","King","Ace"
                };

            foreach (var suits in suit)
            {
                {
                    foreach (var face in faceValue)
                    {
                        _deck.Add(new Card()
                        {
                            suit = suits,
                            faceValue = face
                        });
                    }

                }
            }
        }

        public string Deal(Player player1, Player player2)
        {
            while (_deck.Count >0)
            {
                dealCard(player1);
                dealCard(player2);
            }
            return _sb.ToString();
        }

        private void dealCard(Player player)
        {
            Card card = _deck.ElementAt(_random.Next(_deck.Count));
            player.PlayerCard.Add(card);
            _deck.Remove(card);

            _sb.Append("<br/>");
            _sb.Append(player.Name);
            _sb.Append(" receives ");
            _sb.Append(card.faceValue);
            _sb.Append(" of ");
            _sb.Append(card.suit);
         
        }
    }
}


