﻿using MonsterStore.Decks;
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
                { MonsterAttribute.Earth, 10 },
                { MonsterAttribute.Wind, 56 },
                { MonsterAttribute.Water, 10 },
                { MonsterAttribute.Fire, 4 }
            };

            Name = "Matt";
            Description = "A man whose flatulance is so bad, it can literally clear a room";
        }
    }
}
