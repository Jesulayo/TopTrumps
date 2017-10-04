using MonsterStore;
using MonsterStore.Monsters;
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
            var robotsOut = new List<Guid>();
            Console.ForegroundColor = ConsoleColor.White;
            var war = new Mediator(CompetitorsFactory.GetCompetitors());
            while (war.Monsters.Count(robot => robot.Health > 0) > 1)
            {
                war.NextTurn();
                war.Monsters.OrderBy(monster => monster.Name).ToList().ForEach(monster =>
                {
                    if (monster.Health <= 0)
                    {
                        if (!robotsOut.Contains(monster.Id))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{monster.Name} is out! :(");
                            Console.ForegroundColor = ConsoleColor.White;
                            robotsOut.Add(monster.Id);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{monster.Name} health is {monster.Health.ToString()}");
                    }
                });
                Console.WriteLine("");
                System.Threading.Thread.Sleep(400);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{war.Monsters.SingleOrDefault(r => r.Health > 0).Name} Wins! :)");
            Console.ReadLine();
        }
    }
}