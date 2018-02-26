using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Game
    {
        // compare player 1 vs player 2
        // if player1 card = player2 card
        // play war

        private Player _player1;
        private Player _player2;


        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player() { Name = player1Name };
            _player2 = new Player() { Name = player2Name };
        }

        public string Play()
        {
            Deck deck = new Deck();

            string result = "<h3> Drawing player cards.. </h3>";
            result += deck.Deal(_player1, _player2);
            result += "<h2> The Battle begins... </h2>";

            int round = 0;

            while (_player1.PlayerCard.Count != 0 &&
                   _player2.PlayerCard.Count != 0)
            {
                War war = new War();
                result += war.PlayWar(_player1, _player2);

                round++;
                if (round > 20)
                {
                    break;
                }

            }
            result += determineWinner();
            return result;


        }
        private string determineWinner()
        {
            string result = "";
            if (_player1.PlayerCard.Count > _player2.PlayerCard.Count)
                result += "<br/><span style='color:red;font-weight:bolder;'>Player 1 wins</span>";
            else
                result += "<br/><span style='color:blue;font-weight:bolder;'>Player 2 wins</span>";

            result += "<br/><span style='color:red;font-weight:bolder;'>Player 1:" + _player1.PlayerCard.Count + "</span> <br/><span style='color:blue;font-weight:bolder;'>Player2:" + _player2.PlayerCard.Count + "</span>";
            return result;
        }



    }

        
}