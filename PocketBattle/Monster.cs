using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle
{
    public class Monster
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public IMonster RobotImplementation { get; set; }
        public Int64 Health { get; set; }
        public DateTime LastTurn { get; set; }
    }
}
