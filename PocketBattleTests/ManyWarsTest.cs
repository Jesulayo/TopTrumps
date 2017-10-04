using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PocketBattle;
using System.Linq;
using MonsterStore.Monsters;
using MonsterStore;

namespace PocketBattleTests
{
    [TestClass]
    public class ManyWarsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var monsters = CompetitorsFactory.GetCompetitors();
            var results = monsters.Select(r => new WarResults
            {
                Name = r.GetName(),
                Wins = 0
            }).ToList();

            for (int i = 0; i < 5000; i++)
            {
                var robotsOut = new List<Guid>();
                var war = new Mediator(monsters);

                while (war.Monsters.Count(monster => monster.Health > 0) > 1)
                {
                    war.NextTurn();
                    war.Monsters.OrderBy(monster => monster.Name).ToList().ForEach(monster =>
                    {
                        if (monster.Health <= 0)
                        {
                            if (!robotsOut.Contains(monster.Id))
                            {
                                robotsOut.Add(monster.Id);
                            }
                        }
                    });
                }

                var winningMonster = war.Monsters.Where(b => b.Health > 0).SingleOrDefault();
                results.SingleOrDefault(r => r.Name == winningMonster.Name).Wins++;
            }

            results = results.OrderByDescending(r => r.Wins).ToList();
        }
    }

    public class WarResults
    {
        public String Name { get; set; }
        public Int64 Wins { get; set; }
    }
}
