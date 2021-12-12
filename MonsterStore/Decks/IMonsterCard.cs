using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore.Decks
{
    public interface IMonsterCard
    {
        string Name { get; set; }
        Dictionary<MonsterAttribute, int> Stats { get; set; }
        int Power { get; }
        string Description { get; set; }

        //Random randomNumbers { get; set; }
    }
}
