﻿using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonsterStore
{
    public class FireMonster : IMonsterCard
    {
        public string Name { get; set; }
        public Dictionary<MonsterAttribute, int> Stats { get; set; }
        public int Power => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public FireMonster()
        {
            Stats = new Dictionary<MonsterAttribute, int>
            {
                { MonsterAttribute.Earth, Builder.StatBuilder() },
                { MonsterAttribute.Wind, Builder.StatBuilder() },
                { MonsterAttribute.Water, Builder.StatBuilder() },
                { MonsterAttribute.Fire, Builder.StatBuilder() }
            };

            //Name = "Helios";
            Name = Builder.NameBuilder(this.GetType().Name);
        }
    }
}
