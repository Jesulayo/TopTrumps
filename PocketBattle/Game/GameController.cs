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
                var playerTurn = PlayerStates[turnCounter % 2 > 0 ? 0 : 1];
                var comparer = PlayerStates[turnCounter % 2 > 0 ? 1 : 0];

                //compare
                var attr = playerTurn.Player.DecideAttributeToPlay(playerTurn.CurrentCard);
                Console.WriteLine(Environment.NewLine);
                if (comparer.CurrentCard.Stats[attr.Attr] < attr.Score)
                {
                    Console.WriteLine($"{ playerTurn.Label} WINS ROUND");
                    playerTurn.Deck.Insert(0, comparer.CurrentCard);
                    comparer.Deck.Remove(comparer.CurrentCard);
                }
                else if (comparer.CurrentCard.Stats[attr.Attr] > attr.Score)
                {
                    Console.WriteLine($"{ comparer.Label} WINS ROUND" );
                    comparer.Deck.Insert(0, playerTurn.CurrentCard);
                    playerTurn.Deck.Remove(playerTurn.CurrentCard);
                }
                else
                {
                    Console.WriteLine("Draw");
                    MoveCardToBottom(playerTurn.Deck);
                    MoveCardToBottom(comparer.Deck);
                }
                Console.WriteLine(Environment.NewLine);


                turnCounter++;
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
