using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public interface IBuilder
    {
        int StatBuilder();

        string NameBuilder(IMonsterCard name);
    }
}
