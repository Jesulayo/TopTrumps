using MonsterStore.Decks;
using PocketBattle.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle.Game
{
    public interface IGameController
    {
        IList<IMonsterCard> PlayerOneDeck { get; set; }
        IList<IMonsterCard> PlayerTwoDeck { get; set; }

        IPlayer PlayerOne { get; set; }
        IPlayer PlayerTwo { get; set; }

        void Begin();
    }
}
