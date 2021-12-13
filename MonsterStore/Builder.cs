using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public class Builder : IBuilder
    {
        private Random randomNumber = new Random();

        public int StatBuilder()
        {
            return randomNumber.Next(51);
        }

        public string NameBuilder(IMonsterCard name)
        {
            switch (name)
            {
                case WaterMonster waterMonster:
                    return "Hydro";
                case BalancedMonster balancedMonster:
                    return "Hell Beast";
                case EarthMonster earthMonster:
                    return "Ghia";
                case FireMonster fireMonster:
                    return "Helios";
                case WindMonster windMonster:
                    return "Matt";
                default:
                    return "Barry";
            }
        }
    }
}
