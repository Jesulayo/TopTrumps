using MonsterStore;
using PocketBattle;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PocketBattleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new Mediator();
            var monster = new FireMonster();
            var monster2 = new FireMonster();

            mediator.AddMonster(monster);
            mediator.AddMonster(monster2);

            monster.Attack(monster2, new MonsterAction() { Earth = 10, Fire = 10, Water = 20, Wind = 70 });

            //TODO build class to manage game
        }
    }
}