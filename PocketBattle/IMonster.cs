using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle
{
    public interface IMonster
    {
        // You are passed a list of competitors and you should return this list with 
        // the number of attacks you want to make against each one. 
        // You can only make a total of 10 attacks per turn, otherwise your turn will be voided.
        List<MonsterAction> MyTurn(List<MonsterAction> competitors);

        // Return the name of your robot
        String GetName();

        // Use this to update a provate variable in your class with the current health when called by the mediator.
        // The current level of health with also be stored by the mediator so don't try and cheat.
        void UpdateHealth(Int64 health);

    }
}
