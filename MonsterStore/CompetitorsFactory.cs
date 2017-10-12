using PocketBattle;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public class CompetitorsFactory
    {
        public static IEnumerable<IMonster> GetCompetitors(IMediator m)
        {
            return new List<IMonster>()
            {
                    new FireMonster(m)
            };
        }
    }
}
