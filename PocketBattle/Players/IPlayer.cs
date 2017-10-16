using MonsterStore;
using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle.Players
{
    public interface IPlayer
    {
        (MonsterAttribute Attr, int Score) DecideAttributeToPlay(IMonsterCard m);
    }
}
