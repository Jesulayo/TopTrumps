using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle.Game
{
    public class GameController : IGameController
    {
        public IEnumerable<IMonsterCard> PlayerDeck { get; set; }
        public IEnumerable<IMonsterCard> EnemyDeck { get; set; }

        public void Begin()
        {
            throw new NotImplementedException();
        }

        public void SetDecks(IEnumerable<IMonsterCard> cards)
        {
            throw new NotImplementedException();
        }
    }
}
