using MonsterStore.Decks;
using PocketBattle.Extensions;
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

        private IList<PlayerState> PlayerStates { get; set; }

        public void Begin()
        {
            PlayerStates = new List<PlayerState>
            {
                new PlayerState() { Player = PlayerOne, Deck = PlayerOneDeck, Label = "Player One" },
                new PlayerState() { Player = PlayerTwo, Deck = PlayerTwoDeck, Label = "Player Two" }
            };

            var turnCounter = 1;

            while (PlayerStates.All(state => state.Deck.Count() != 0))
            {
                //take card from top of each deck
                PlayerStates[0].CurrentCard = PlayTopCard(PlayerStates[0].Deck);
                PlayerStates[1].CurrentCard = PlayTopCard(PlayerStates[1].Deck);

                //determine whose go it is
                var activePlayer = PlayerStates[turnCounter % 2 > 0 ? 0 : 1];
                var defendingPlayer = PlayerStates[turnCounter % 2 > 0 ? 1 : 0];

                //compare
                var attr = activePlayer.Player.DecideAttributeToPlay(activePlayer.CurrentCard);
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"{activePlayer.Label} played {activePlayer.CurrentCard.Name}");
                Console.WriteLine($"{defendingPlayer.Label} played {defendingPlayer.CurrentCard.Name}");
                Console.WriteLine($"{activePlayer.Label} chose to play {attr.Attr} with a score of {attr.Score}");
                var comparerScore = defendingPlayer.CurrentCard.Stats[attr.Attr];

                if (comparerScore < attr.Score)
                {
                    Console.WriteLine($"{ activePlayer.Label} WINS ROUND with a attribute score of {attr.Score} compared to {comparerScore}");
                    activePlayer.Deck.Insert(0, defendingPlayer.CurrentCard);
                    defendingPlayer.Deck.Remove(defendingPlayer.CurrentCard);
                }
                else if (comparerScore > attr.Score)
                {
                    Console.WriteLine($"{ defendingPlayer.Label} WINS ROUND with a score of {comparerScore} compared to {attr.Score}" );
                    defendingPlayer.Deck.Insert(0, activePlayer.CurrentCard);
                    activePlayer.Deck.Remove(activePlayer.CurrentCard);
                }
                else
                {
                    Console.WriteLine("Draw");
                    MoveCardToBottom(activePlayer.Deck);
                    MoveCardToBottom(defendingPlayer.Deck);
                }
                Console.WriteLine(Environment.NewLine);


                turnCounter++;
                Console.WriteLine("Current Deck Status: " + String.Join(",", PlayerStates.Select(p => p.Deck.Count())));
                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine($"The Winner is: {PlayerStates.First(player => player.Deck.Any()).Label}");
            Console.ReadKey();
        }

        private IMonsterCard PlayTopCard(IList<IMonsterCard> deck)
        {
            return deck[deck.Count() - 1];
        }

        private void MoveCardToBottom(IList<IMonsterCard> deck)
        {
            var top = deck.Count() - 1;
            var c = deck[top];
            deck.RemoveAt(top);
            deck.Insert(0, c);
        }



    }
}
