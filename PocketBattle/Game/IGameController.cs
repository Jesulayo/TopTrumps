using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle.Game
{
    public interface IGameController
    {
        IEnumerable<IMonsterCard> PlayerDeck { get; set; }
        IEnumerable<IMonsterCard> EnemyDeck { get; set; }
        void SetDecks(IEnumerable<IMonsterCard> cards);
        void Begin();
    }
}
