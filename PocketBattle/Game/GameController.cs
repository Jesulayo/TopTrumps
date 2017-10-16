using MonsterStore.Decks;
using PocketBattle.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocketBattle.Game
{
    public class GameController : IGameController
    {
        public IList<IMonsterCard> PlayerOneDeck { get; set; }
        public IList<IMonsterCard> PlayerTwoDeck { get; set; }

        public IPlayer PlayerOne { get; set; }
        public IPlayer PlayerTwo { get; set; }

        public void Begin()
        {
            var turnCounter = 0;
            while (PlayerOneDeck.Any() && PlayerTwoDeck.Any())
            {
                var playerOneCard = PlayTopCard(PlayerOneDeck);
                var playerTwoCard = PlayTopCard(PlayerTwoDeck);

                if (turnCounter % 2 == 0)
                {
                    var attr = PlayerOne.DecideAttributeToPlay(playerOneCard);
                    Console.WriteLine(Environment.NewLine);
                    if (playerTwoCard.Stats[attr.Attr] > attr.Score)
                    {
                        Console.WriteLine("PLAYER TWO WINS");
                        PlayerTwoDeck.Add(playerOneCard);
                        PlayerOneDeck.Remove(playerOneCard);
                    }
                    else
                    {
                        Console.WriteLine("PLAYER ONE WINS");
                        PlayerOneDeck.Add(playerTwoCard);
                        PlayerTwoDeck.Remove(playerTwoCard);
                    }
                    Console.WriteLine(Environment.NewLine);
                }
                else
                {
                    var attr = PlayerTwo.DecideAttributeToPlay(playerTwoCard);
                    Console.WriteLine(Environment.NewLine);
                    if (playerOneCard.Stats[attr.Attr] > attr.Score)
                    {
                        Console.WriteLine("PLAYER ONE WINS");
                        PlayerOneDeck.Add(playerTwoCard);
                        PlayerTwoDeck.Remove(playerTwoCard);
                    }
                    else
                    {
                        Console.WriteLine("PLAYER TWO WINS");
                        PlayerTwoDeck.Add(playerOneCard);
                        PlayerOneDeck.Remove(playerOneCard);
                    }

                    Console.WriteLine(Environment.NewLine);
                }


                turnCounter++;
            }

            Console.WriteLine($"The Winner is: {DeclareWinner()}");
        }

        private IMonsterCard PlayTopCard(IList<IMonsterCard> deck)
        {
            return deck[deck.Count() - 1];
        }

        private string DeclareWinner()
        {
            return PlayerOneDeck.Any() ? "Player One" : "Player 2";
        }
    }
}
