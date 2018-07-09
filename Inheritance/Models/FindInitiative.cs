using System;

namespace Inheritance.Models
{
    public class FindInitiative
    {
        public FindInitiative(HumanFighter human1, Rat rat1)
        {
            var playerInitiative = human1.Initiative;
            var enemyInitiative = rat1.Initiative;
            var playerTurn = false;

            // if the player's ini and enemies ini match, create new random inis
            while (playerInitiative == enemyInitiative)
            {
                var ini = new Random();
                enemyInitiative = ini.Next(rat1.Initiative);
                playerInitiative = ini.Next(human1.Initiative);
            }
            playerTurn = (playerInitiative > enemyInitiative) ? true : false;
        }
    }
}
