using System;
using Inheritance.Enums;
using Inheritance.Helper;
using Inheritance.Interfaces;
using Inheritance.Models;

namespace Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var player = ClassService.GetBase("Cool Barbarian Steve", BaseClass.Barbarian, true, new Stat(), WeaponClass.Club);
            var enemy = ClassService.GetBase("Very Evil Kobold", BaseClass.Cleric, false, new Stat(), WeaponClass.Dagger);
            var playerWeapon = WeaponService.GetWeapon("Club", WeaponClass.Club);
            var enemyWeapon = WeaponService.GetWeapon("Dagger", WeaponClass.Dagger);

            Helper.Program.DisplayCharacters.DisplayCharacter(player);
            Helper.Program.DisplayCharacters.DisplayCharacter(enemy);

            var combatService = new CombatService(player, enemy, playerWeapon, enemyWeapon);
            
            Console.ReadLine();
        }
    }
}
