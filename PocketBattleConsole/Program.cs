using MonsterStore;
using MonsterStore.Decks;
using PocketBattle;
using PocketBattle.Game;
using PocketBattle.Players;
using PocketBattle.ServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PocketBattleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var locator = new ServiceLocator();
            var controller = locator.GetService<IGameController>();
            var cardFactory = locator.GetService<BaseMonsterFactory>();

            //1. Get the deks for both players

            var humanDeck = new List<IMonsterCard>();
            var AiDeck = new List<IMonsterCard>();

            for(int i = 0; i <= 4; i++)
            {
                humanDeck.Add(cardFactory.GetCard());
                AiDeck.Add(cardFactory.GetCard());
            }

            //2. Set decks in game controller
            controller.PlayerOneDeck = humanDeck;
            controller.PlayerTwoDeck = AiDeck;

            controller.PlayerOne = new Human();
            controller.PlayerTwo = new BasicAI();

            //3. LET THE GAMES BEGIN
            controller.Begin();

        }
    }
}