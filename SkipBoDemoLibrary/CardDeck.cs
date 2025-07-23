using Stripe.Terminal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Cryptography;

namespace SkipBoDemoLibrary
{
    public class CardDeck
    {
        public List<int> NumberedCards = new List<int>();
        public List<string> SkipBoCards = new List<string>();
        public List<object> FullDeck = new List<object>();
        public List<object> PlayingDeck = new List<object>();
        public List<object> StockPile = new List<object>();

        public CardDeck()
        {
            CreateFullDeck();
            ShuffleDeck();
        }
        private void CreateDeckNumbers()
        {
            while (NumberedCards.Count < 144)
            {
                NumberedCards.Add(1);
                NumberedCards.Add(2);
                NumberedCards.Add(3);
                NumberedCards.Add(4);
                NumberedCards.Add(5);
                NumberedCards.Add(6);
                NumberedCards.Add(7);
                NumberedCards.Add(8);
                NumberedCards.Add(9);
                NumberedCards.Add(10);
                NumberedCards.Add(11);
                NumberedCards.Add(12);
            }
        }
        private void CreateSkipBoCards()
        {
            while (SkipBoCards.Count < 18)
            {
                SkipBoCards.Add("Skip-Bo");
            }
        }
        private void ShuffleDeck()
        {
            Random.Shared.Shuffle(System.Runtime.InteropServices.CollectionsMarshal.AsSpan(FullDeck));
        }
        private void CreateFullDeck()
        {
            CreateDeckNumbers();
            CreateSkipBoCards();
            FullDeck.AddRange(NumberedCards.Cast<object>());
            FullDeck.AddRange(SkipBoCards.Cast<object>());
        }
        public void DealStockPileCards(PlayerModel player)
        {
            var output = FullDeck.Take(1).First().ToString();
            player.StockPile.Add(output);
            FullDeck.RemoveRange(0,1);
        }
        public void DrawCards(PlayerModel player)
        {
            do
            {
                var output = FullDeck.Take(1).First().ToString();
                player.PlayingCards.Add(output);
                FullDeck.RemoveRange(0, 1);
            } while (player.PlayingCards.Count < 5);
        }

    }
}
