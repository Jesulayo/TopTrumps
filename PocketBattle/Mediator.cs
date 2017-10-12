using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace PocketBattle
{
    public class Mediator : IMediator
    {
        public List<IMonster> Monsters { get; set; } = new List<IMonster>();

        public void AddMonster(IMonster monster)
        {
            if (Monsters.Contains(monster) == false)
            {
                monster.Mediator = this;
                Monsters.Add(monster);
            }
        }

        public void Attack(IMonster sender, IMonster to, MonsterAction attack)
        {
            sender.DefendAttack(sender, attack);
        }
    }
}
