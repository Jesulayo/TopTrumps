﻿using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonsterStore
{
    public class WeakMonster : IMonsterCard
    {
        public string Name { get; set; }
        public Dictionary<MonsterAttribute, int> Stats { get; set; }
        public int Power => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public WeakMonster(IBuilder builder)
        {
            Stats = new Dictionary<MonsterAttribute, int>
            {
                { MonsterAttribute.Earth, builder.StatBuilder() },
                { MonsterAttribute.Wind, builder.StatBuilder() },
                { MonsterAttribute.Water, builder.StatBuilder() },
                { MonsterAttribute.Fire, builder.StatBuilder() }
            };

            //Name = "Barry";
            Name = RandomNumber.NameBuilder(this.GetType().Name);
        }
    }
}
