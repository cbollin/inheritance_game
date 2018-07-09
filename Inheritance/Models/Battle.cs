using System;

namespace Inheritance.Models
{
    public class Battle
    {
        public static void BeginCombat(HumanFighter player, Rat enemy)
        {

            const int deathRip = 0;
            var playerInitiative = player.Initiative;
            var enemyInitiative = enemy.Initiative;
            var playerTurn = false;

            // if the player's ini and enemies ini match, create new random inis
            while (playerInitiative == enemyInitiative)
            {
                var ini = new Random();
                enemyInitiative = ini.Next(enemy.Initiative);
                playerInitiative = ini.Next(player.Initiative);
            }
            playerTurn = (playerInitiative > enemyInitiative) ? true : false;

            //TODO: Multiple enemies + Add player weapons
            //each player and enemy is assigned an ini - then they loop until either
            //all players are dead or all enemies are dead
            //construct enemy parties
            // for each enemy in enemy party, assign them inis then all them to battle


            Console.WriteLine("Welcome to the battle simulator.");
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();
            Console.WriteLine($"{player.Name} unsheaths their {player.Shortsword.Name}.");
            Console.WriteLine($"This weapon has the following properties:");
            Console.WriteLine($"{player.Shortsword.Type} {player.Shortsword.DamageType} {player.Shortsword.Properties[0]}");
            while (enemy.HealthPoints >= deathRip || player.HealthPoints >= deathRip)
            {
                Console.ReadKey();
                if (playerTurn)
                {
                    var playerAttack = player.Attack();
                    var enemyHealth = enemy.HealthPoints -= playerAttack;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (playerAttack == deathRip)
                    {
                        Console.WriteLine($"Critical Miss!");
                        Console.WriteLine($"{player.Name} deals {playerAttack} {player.Shortsword.DamageType.ToLower()} damage to {enemy.Name}.");
                        playerTurn = false;
                    }
                    if (playerAttack >= player.Strength + player.Shortsword.Damage)
                    {

                        Console.WriteLine("Critical Hit!");
                        Console.WriteLine($"{player.Name} deals {playerAttack * 2} {player.Shortsword.DamageType.ToLower()} damage to {enemy.Name}.");
                        playerTurn = false;
                    }
                    else
                    {
                        Console.WriteLine($"{player.Name} deals {playerAttack} {player.Shortsword.DamageType.ToLower()} damage to {enemy.Name}.");
                        playerTurn = false;
                    }
                    if (enemyHealth <= deathRip)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have slain your enemy!");
                        break;
                    }
                    Console.WriteLine($"{enemy.Name} has {enemyHealth} health remaining.");
                }
                else
                {
                    var enemyAttack = enemy.Attack();
                    var playerHealth = player.HealthPoints -= enemyAttack;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{enemy.Name} deals {enemyAttack} damage to {player.Name}.");
                    playerTurn = true;
                    if (player.HealthPoints <= deathRip)
                    {
                        Console.WriteLine("You have been slain!");
                        break;
                    }
                    Console.WriteLine($"{player.Name} has {playerHealth} health remaining.");
                }
            }
            Console.ReadLine();
        }
    }
}
