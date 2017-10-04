using PocketBattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonsterStore.Monsters
{
    public class LazyRobot : IMonster
    {
        public Int64 Health { get; set; }

        public string GetName()
        {
            return "Lazy Robot";
        }

        public List<MonsterAction> MyTurn(List<MonsterAction> competitors)
        {
            var random = new Random();
            var victim = competitors[random.Next(0, competitors.Count - 1)];
            victim.Attacks = 10;
            return competitors;
        }

        public void UpdateHealth(Int64 health)
        {
            Health = health;
        }
    }
}
