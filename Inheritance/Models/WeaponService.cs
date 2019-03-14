using System;
using System.Collections.Generic;
using Inheritance.Enums;
using Inheritance.Helper;
using Inheritance.Interfaces;

namespace Inheritance.Models
{
    public static class WeaponService
    {
        public static IWeapon GetWeapon(string name, WeaponClass weapon)
        {
            var item = new Weapon(name, weapon);

            switch (weapon)
            {
                case WeaponClass.Unarmed:
                    item.Type = "Melee";
                    item.Category = "Items";
                    item.Damage.Current = Randomizer.GetRandom(1, 3);
                    item.Damage.Base = 1;
                    item.DamageType = "Bludgeoning";
                    item.ItemRarity = "Standard";
                    item.Properties = new List<string> { "None" };
                    item.Weight = 0;
                    break;
                case WeaponClass.Club:
                    item.Type = "Melee";
                    item.Category = "Items";
                    item.Damage.Current = Randomizer.GetRandom(1,4);
                    item.Damage.Base = 2;
                    item.DamageType = "Bludgeoning";
                    item.ItemRarity = "Standard";
                    item.Properties = new List<string> { "Light" };
                    item.Weight = 2;
                    break;
                case WeaponClass.Dagger:
                    item.Type = "Melee";
                    item.Category = "Items";
                    item.Damage.Current = Randomizer.GetRandom(1, 4);
                    item.DamageType = "Piercing";
                    item.ItemRarity = "Standard";
                    item.Properties = new List<string> { "Finesse", "Light", "Range", "Thrown" };
                    item.Weight = 2;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(weapon), weapon, null);
            }
            return item;
        }
    }
}