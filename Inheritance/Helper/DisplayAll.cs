using System;
using Inheritance.Interfaces;

namespace Inheritance.Helper
{
    class Program
    {
        public class DisplayCharacters
        {
            public static void DisplayCharacter(IBase player)
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"Name: {player.Name} - Class: {player.Class}");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"HP: {player.HealthPoints.Current}/{player.HealthPoints.Base}");
                Console.WriteLine($"Level: {player.Level.Current}");
                Console.WriteLine($"Experience: {player.Level.Current}");
                Console.WriteLine($"Strength: {player.Strength.Current}");
                Console.WriteLine($"Weapon Equipped: {player.HasWeapon}");
                Console.WriteLine("##########################################################");
                Console.WriteLine("\n");
            }
        }
    }
}
