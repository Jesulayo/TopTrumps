using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public static class RandomNumber
    {
        public static Random randomNumber = new Random();

        public static int GenerateRandomNumber()
        {
            return randomNumber.Next(51);
        }

        public static string NameBuilder(string name)
        {
            //var c = typeof(WaterMonster).Name;
            var monsterName = name.Substring(0, name.Length - 7);
            switch (monsterName.ToLower())
            {
                case "water":
                    return "Hydro";
                case "balanced":
                    return "Hell Beast";
                case "earth":
                    return "Ghia";
                case "fire":
                    return "Helios";
                case "wind":
                    return "Matt";
                case "superg":
                    return "SuperG";
                default:
                    return "Barry";
            }
        }
    }
}
