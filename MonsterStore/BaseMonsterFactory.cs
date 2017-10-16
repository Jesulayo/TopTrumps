using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public abstract class BaseMonsterFactory
    {
        public abstract IMonsterCard GetCard();
    }
}
