using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonsterStore
{
    public class BalancedMonster : IMonsterCard
    {
        public string Name { get; set; }
        public Dictionary<MonsterAttribute, int> Stats { get; set; }
        public int Power => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public BalancedMonster()
        {
            Stats = new Dictionary<MonsterAttribute, int>
            {
                { MonsterAttribute.Earth, 10 },
                { MonsterAttribute.Wind, 10 },
                { MonsterAttribute.Water, 10 },
                { MonsterAttribute.Fire, 90 }
            };

            Name = "Hell Beast";
        }
    }
}
