using MonsterStore.Decks;
using PocketBattle.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle.Game
{
    public class PlayerState
    {
        public IPlayer Player { get; set; }
        public IMonsterCard CurrentCard { get; set; }
        public IList<IMonsterCard> Deck { get; set; }
        public string Label { get; set; }
    }
}
