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
                { MonsterAttribute.Earth, RandomNumber.randomNumber.Next(51) },
                { MonsterAttribute.Wind, RandomNumber.randomNumber.Next(51) },
                { MonsterAttribute.Water, RandomNumber.randomNumber.Next(51) },
                { MonsterAttribute.Fire, RandomNumber.randomNumber.Next(51) }
            };

            Name = "Hell Beast";
        }
    }
}
