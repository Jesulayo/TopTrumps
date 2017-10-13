using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle.Decks
{
    public interface IMonsterCard
    {
        string Name { get; set; }
        Dictionary<MonsterAttribute, int> Stats { get; set; }

        IMediator Mediator { get; set; }

        void DefendAttack(IMonsterCard fromMonster, MonsterAction attack);
        void Attack(IMonsterCard toMonster, MonsterAction attack);
        void AllocateHealth(int source);
    }
}
