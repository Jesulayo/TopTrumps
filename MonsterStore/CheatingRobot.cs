using PocketBattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonsterStore.Monsters
{
    public class CheatingRobot : IMonster
    {
        public Int64 Health { get; set; }

        public string GetName()
        {
            return "Cheating Robot";
        }

        public List<MonsterAction> MyTurn(List<MonsterAction> competitors)
        {
            competitors.ForEach(c =>
            {
                c.Attacks = 1000000;
            });
            return competitors;
        }

        public void UpdateHealth(Int64 health)
        {
            Health = health;
        }
    }
}
