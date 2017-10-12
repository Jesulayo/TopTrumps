using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle
{
    public interface IMediator
    {
        void Attack(IMonster sender, IMonster to, MonsterAction attack);
        void AddMonster(IMonster monster);
    }
}
