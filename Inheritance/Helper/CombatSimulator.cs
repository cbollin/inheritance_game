using System;
using System.Threading;
using Inheritance.Enums;
using Inheritance.Interfaces;

namespace Inheritance.Helper
{
    //Start combat and continue until enemy or player is defeated.
    public class CombatService
    {
        public CombatService(IBase player, IBase enemy, IWeapon playerWeapon, IWeapon enemyWeapon)
        {
            //while the player's current hp is greater than 0 or enemy hp is greater than 0, attack each other
            //if the enemy's hp drops to 0 or less, exit loop
            var aliveCheck = true;

            while (aliveCheck)
            {

                if (player.Initiative.Current >= enemy.Initiative.Current)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{player.Name}'s Turn");
                    Thread.Sleep(500);
                    Console.WriteLine($"{player.Name} has {player.HealthPoints.Current} hit points remaining!");
                    Thread.Sleep(500);
                    player.Attack(enemy, player, playerWeapon, enemyWeapon);
                    Thread.Sleep(500);

                    player.Initiative.Current = enemy.Initiative.Current - 1;

                    Thread.Sleep(1000);

                    if (enemy.HealthPoints.Current < 1)
                    {
                        aliveCheck = false;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{enemy.Name} has fallen!");
                        break;
                    }
                }
                if (enemy.Initiative.Current > player.Initiative.Current)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{enemy.Name}'s Turn");
                    Thread.Sleep(500);
                    Console.WriteLine($"{enemy.Name} has {enemy.HealthPoints.Current}'s hit points remaining!");
                    Thread.Sleep(500);
                    enemy.Attack(enemy, player, playerWeapon, enemyWeapon);
                    Thread.Sleep(500);

                    enemy.Initiative.Current = player.Initiative.Current - 1;

                    Thread.Sleep(1000);

                    if (player.HealthPoints.Current < 1)
                    {
                        aliveCheck = false;
                        Console.WriteLine($"{player.Name} has fallen..");
                        break;
                    }
                }
            }
        }
    }
}

