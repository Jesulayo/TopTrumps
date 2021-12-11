using MonsterStore.Decks;
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

        public WeakMonster()
        {
            Stats = new Dictionary<MonsterAttribute, int>
            {
                { MonsterAttribute.Earth, RandomNumber.GenerateRandomNumber() },
                { MonsterAttribute.Wind, RandomNumber.GenerateRandomNumber() },
                { MonsterAttribute.Water, RandomNumber.GenerateRandomNumber() },
                { MonsterAttribute.Fire, RandomNumber.GenerateRandomNumber() }
            };

            //Name = "Barry";
            Name = RandomNumber.NameBuilder(this.GetType().Name);
        }
    }
}
