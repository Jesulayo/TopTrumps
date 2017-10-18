using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public class RandomMonsterCardFactory : BaseMonsterFactory
    {
        public override IMonsterCard GetCard()
        {
            var ran = new Random();
            var choose = ran.Next(1, 5);
            switch (choose)
            {
                case 1:
                    return new WindMonster();
                case 2:
                    return new FireMonster();
                case 3:
                    return new EarthMonster();
                case 4:
                    return new WaterMonster();
                case 5:
                    return new BalancedMonster();
                default:
                    return new WeakMonster();
            }
        }
    }
}
