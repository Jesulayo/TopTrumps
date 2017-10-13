using PocketBattle;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public class CompetitorsFactory
    {
        public static IEnumerable<IMonsterCard> GetCompetitors(IMediator m)
        {
            return new List<IMonsterCard>()
            {
                    new FireMonster(m)
            };
        }
    }
}
