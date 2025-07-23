using SkipBoDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
CardDeck cardDeck = new CardDeck();
GameLogic gameLogic = new GameLogic();
PlayerModel activePlayer = new PlayerModel();
activePlayer.PlayerTitle = "Player One";
PlayerModel opponent = new PlayerModel();
opponent.PlayerTitle = "Player Two";
PlayerModel winner = null;
do
{
    cardDeck.DealStockPileCards(activePlayer);
    cardDeck.DealStockPileCards(opponent);
} while (activePlayer.StockPile.Count < 30 && opponent.StockPile.Count < 30);
//Test code.
activePlayer.StockPile.Clear();
do
{

    bool doesGameContinue = GameLogic.DoesGameContinue(opponent);
    
    if (doesGameContinue)
    {
        (activePlayer, opponent) = (opponent, activePlayer);
    }
    else
    {
        winner = activePlayer;
    }

} while (winner == null);
Console.WriteLine($"The winner is {activePlayer.PlayerTitle}");




Console.ReadLine();