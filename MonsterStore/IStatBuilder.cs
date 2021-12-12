using MonsterStore.Decks;

namespace MonsterStore
{
    public interface IBuilder
    {
        int StatBuilder();

        string NameBuilder(IMonsterCard name);
    }
}