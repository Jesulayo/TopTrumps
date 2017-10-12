using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle
{
    public interface IMonster
    {
        string Name { get; set; }
        int Health { get; }
        int Fire { get; set; }
        int Wind { get; set; }
        int Water { get; set; }
        int Earth { get; set; }
        bool IsKO { get; }

        IMediator Mediator { get; set; }

        void DefendAttack(IMonster fromMonster, MonsterAction attack);
        void Attack(IMonster toMonster, MonsterAction attack);
        void AllocateHealth(int source);
    }
}
