using MonsterStore;
using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle.AI
{
    public interface IArtificialIntelligence
    {
        MonsterAttribute DecideAttributeToPlay(IMonsterCard m);
    }
}
