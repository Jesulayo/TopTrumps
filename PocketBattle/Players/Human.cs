using System;
using System.Collections.Generic;
using System.Text;
using MonsterStore;
using MonsterStore.Decks;
using System.Linq;

namespace PocketBattle.Players
{
    public class Human : IPlayer
    {
        public (MonsterAttribute Attr, int Score) DecideAttributeToPlay(IMonsterCard m)
        {
            Console.WriteLine($"You pulled card {m.Name} ({m.Description})");
            var c = 1;
            Console.WriteLine("Choose your attribute to play...");
            foreach (var stat in m.Stats)
            {
                Console.WriteLine($"{c} - {stat.Key} \t\t\t {stat.Value}");
                c++;
            }

            var choice = Console.ReadKey().KeyChar.ToString();


            if (int.TryParse(choice, out int i))
            {
                return (m.Stats.ToList()[i - 1].Key, m.Stats.ToList()[i - 1].Value);
            }
            else
            {
                Console.WriteLine("Invalid Choice...");
                DecideAttributeToPlay(m);
            }

            return (MonsterAttribute.Earth, 0);

        }
    }
}
