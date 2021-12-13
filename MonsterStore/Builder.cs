using MonsterStore.Decks;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterStore
{
    public class Builder : IBuilder
    {
        private Random randomNumber = new Random();

        public int StatBuilder()
        {
            return randomNumber.Next(51);
        }
    }
}
