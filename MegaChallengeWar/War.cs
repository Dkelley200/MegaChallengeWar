using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace MegaChallengeWar
{

   public class War
    {
        private List<Card> _bounty;
        private StringBuilder _sb;

        public War()
        {
            _bounty = new List<Card>();
            _sb = new StringBuilder();
        }

        public string PlayWar(Player player1, Player player2)
        {
            Card player1Card = getCard(player1);
            Card player2card = getCard(player2);

            performEvaluation(player1, player2, player1Card, player2card);
            return _sb.ToString();
        }

        private Card getCard(Player player)
        {
            Card card = player.PlayerCard.ElementAt(0);
            player.PlayerCard.Remove(card);
            _bounty.Add(card);
            return card;
        }

        private void performEvaluation(Player player1, Player player2, Card player1Card, Card player2card)
        {
            displayBattleCards(player1Card, player2card);
            if (player1Card.CardValue() == player2card.CardValue())
                battle(player1, player2);
            if (player1Card.CardValue() > player2card.CardValue())
                awardWinner(player1);
            else
                awardWinner(player2);
        }

        private void awardWinner(Player player)
        {
            if (_bounty.Count == 0) return;
            displayBountyCards();
            player.PlayerCard.AddRange(_bounty);
            _bounty.Clear();

            _sb.Append("<br/><strong/>");
            _sb.Append(player.Name);
            _sb.Append("Wins!</strong><br/>");
        }

        private void displayBountyCards()
        {
            _sb.Append("<br/>Bounty...");
            foreach (var playerCard in _bounty)
            {
                _sb.Append("</br/>&nbsp;&nbsp;&nbsp;&nbsp;");
                _sb.Append(playerCard.faceValue);
                _sb.Append(" of ");
                _sb.Append(playerCard.suit);
            }
        }

        private void battle(Player player1, Player player2)
        {
            _sb.Append("<br/>************WAR***************<br/>");
            getCard(player1);
            Card warCard1 = getCard(player1);
            getCard(player1);

            getCard(player2);
            Card warCard2 = getCard(player2);
            getCard(player2);

            performEvaluation(player1, player2, warCard1, warCard2);
        }

        private void displayBattleCards(Card player1Card, Card player2card)
        {
            _sb.Append("<br/>Battle Cards: "); 
            _sb.Append(player1Card.faceValue);
            _sb.Append(" of ");
            _sb.Append(player1Card.suit);
            _sb.Append(" versus ");
            _sb.Append(player2card.faceValue);
            _sb.Append(" of ");
            _sb.Append(player2card.suit);
           
        }
    }
}
