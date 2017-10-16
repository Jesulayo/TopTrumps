using MonsterStore;
using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocketBattle.AI
{
    public class BasicAI : IArtificialIntelligence
    {
        public MonsterAttribute DecideAttributeToPlay(IMonsterCard m)
        {
            //we just play the highest attribute we have - simple
            return m.Stats.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }
    }
}
