using System;
using System.Collections.Generic;
using Inheritance.Enums;
using Inheritance.Interfaces;
using Inheritance.Models;

namespace Inheritance.Models
{
    public class Weapon : IWeapon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public Stat Damage { get; set; }
        public string DamageType { get; set; }
        public string ItemRarity { get; set; }
        public List<string> Properties { get; set; }
        public int Weight { get; set; }
        public decimal Cost { get; set; }

        public Weapon(string name, WeaponClass item)
        {
            Name = name;
            Type = Type;
            Category = Category;
            Damage = new Stat();
            DamageType = DamageType;
            ItemRarity = ItemRarity;
            Properties = Properties;
            Weight = Weight;
            Cost = Cost;
        }
    }
}