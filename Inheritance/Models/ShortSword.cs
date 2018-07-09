using Inheritance.Interfaces;
using System;
using System.Collections.Generic;

namespace Inheritance.Models
{
    public class ShortSword : IWeapons
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public decimal Cost { get; set; }
        public int Damage { get; set; }
        public string DamageType { get; set; }
        public string ItemRarity { get; set; }
        public List<string> Properties { get; set; } = new List<string>();
        public int Weight { get; set; }

        private readonly Random _rnd = new Random();
        public ShortSword()
        {
            Name = "Short Sword";
            Type = "Melee";
            Category = "Items";
            Damage = _rnd.Next(1, 7);
            DamageType = "Piercing";
            ItemRarity = "Standard";
            Properties.Add("Finesse");
            Properties.Add("Light");
            Weight = 2;
            Cost = 30;
        }
    }
}
