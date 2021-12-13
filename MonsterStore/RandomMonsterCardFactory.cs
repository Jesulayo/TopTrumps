using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public class RandomMonsterCardFactory : BaseMonsterFactory
    {
        private readonly IBuilder builder;

        public RandomMonsterCardFactory(IBuilder builder)
        {
            this.builder = builder;
        }
        public override IMonsterCard GetCard()
        {
            var ran = new Random();
            var choose = ran.Next(1,8);
            switch (choose)
            {
                case 1:
                    return new WindMonster(builder);
                case 2:
                    return new FireMonster(builder);
                case 3:
                    return new EarthMonster(builder);
                case 4:
                    return new WaterMonster(builder);
                case 5:
                    return new BalancedMonster(builder);
                case 6:
                    return new SuperGMonster(builder);
                default:
                    return new WeakMonster(builder);
            }
        }
    }
}
