using MonsterStore.Monsters;
using PocketBattle;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public class CompetitorsFactory
    {
        public static List<IMonster> GetCompetitors()
        {
            return new List<IMonster>()
            {
                    new BullyRobot(),
                    new CheatingRobot(),
                    new CompassionateRobot(),
                    new LazyRobot(),
                    new StupidRobot(),
                    new VeryStupidRobot()
            };
        }
    }
}
