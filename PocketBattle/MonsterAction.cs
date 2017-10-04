using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle
{
    public class MonsterAction
    {
        public Guid Id { get; set; }
        public String Name { get; set; }

        // Shows their current state of health
        public Int64 Health { get; set; }

        // Set this to specify how many attacks to make against them
        public Int64 Attacks { get; set; }
    }
    
}
