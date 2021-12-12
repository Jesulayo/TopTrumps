using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonsterStore
{
    public class WindMonster : IMonsterCard
    {
        public string Name { get; set; }
        public Dictionary<MonsterAttribute, int> Stats { get; set; }
        public int Power => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public WindMonster()
        {
            Stats = new Dictionary<MonsterAttribute, int>
            {
                { MonsterAttribute.Earth, Builder.StatBuilder() },
                { MonsterAttribute.Wind, Builder.StatBuilder() },
                { MonsterAttribute.Water, Builder.StatBuilder() },
                { MonsterAttribute.Fire, Builder.StatBuilder() }
            };

            //Name = "Matt";
            Description = "A man whose flatulance is so bad, it can literally clear a room";
            Name = Builder.NameBuilder(this.GetType().Name);
        }
    }
}
