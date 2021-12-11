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
    }
}
