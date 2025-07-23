using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkipBoDemoLibrary
{
    public class GameLogic
    {
        public List<string> BuildingPileOne { get; set; } = new List<string>();
        public List<string> BuildingPileTwo { get; set; } = new List<string>();
        public List<string> BuildingPileThree { get; set; } = new List<string>();
        public List<string> BuildingPileFour { get; set; } = new List<string>();

        public static bool DoesGameContinue(PlayerModel player)
        {
            bool isWinner = false;

                if (player.StockPile.Count == 0)
                {
                    isWinner = true;
                }
            return isWinner;
        }
        public void PlayersTurn(PlayerModel player, CardDeck cardDeck)
        {
            cardDeck.DrawCards(player);
            if (player.PlayingCards.Count == 0)
            {
                cardDeck.DrawCards(player);
                cardDeck.DrawCards(player);
            }

        }
    }
}

