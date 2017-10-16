using MonsterStore;
using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PocketBattle.Players
{
    public class BasicAI : IPlayer
    {
        public (MonsterAttribute Attr, int Score) DecideAttributeToPlay(IMonsterCard m)
        {
            //we just play the highest attribute we have - simple
            //pretend to think
            Console.WriteLine("Thinking....");
            Thread.Sleep(3000);
            var attr =  m.Stats.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            return (attr, m.Stats[attr]);
        }
    }
}
