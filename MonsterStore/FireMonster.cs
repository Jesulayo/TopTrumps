using PocketBattle;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public class FireMonster : IMonster
    {
        public string Name { get; set; }
        public int Health  => Fire + Wind + Water + Earth;
        public int Fire { get; set; }
        public int Wind { get; set; }
        public int Water { get; set; }
        public int Earth { get; set; }
        public IMediator Mediator { get; set; }
        public bool IsKO => Health <= 0;

        public FireMonster(IMediator m)
        {
            Mediator = m;
        }

        public FireMonster()
        {

        }

        public void Attack(IMonster toMonster, MonsterAction attack)
        {
            Mediator.Attack(this, toMonster, new MonsterAction());
        }

        public void DefendAttack(IMonster fromMonster, MonsterAction attack)
        {
            Fire -= attack.Fire;
            Wind -= attack.Wind;
            Water -= attack.Water;
            Earth -= attack.Earth;
        }

        public void AllocateHealth(int source)
        {
            Fire = source;
        }
    }
}
