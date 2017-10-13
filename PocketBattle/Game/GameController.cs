using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle.Game
{
    public class GameController : IGameController
    {
        public IEnumerable<IMonsterCard> PlayerDeck { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<IMonsterCard> EnemyDeck { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
