using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonsterStore
{
    public class EarthMonster : IMonsterCard
    {
        public string Name { get; set; }
        public Dictionary<MonsterAttribute, int> Stats { get; set; }
        public int Power => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public EarthMonster()
        {
            Stats = new Dictionary<MonsterAttribute, int>
            {
                { MonsterAttribute.Earth, 78 },
                { MonsterAttribute.Wind, 3 },
                { MonsterAttribute.Water, 2 },
                { MonsterAttribute.Fire, 2 }
            };

            Name = "Ghia";
        }
    }
}
