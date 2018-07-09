using Inheritance.Interfaces;
using System;

namespace Inheritance.Models
{
    public class HumanFighter : IBaseStats, IStatBlocks
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int HealthPoints { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }

        public ShortSword Shortsword { get; } = new ShortSword();

        public HumanFighter()
        {
            Name = "Tim";
            Strength = 8;
            Constitution = 1;
            Dexterity = 1;
            Intelligence = 1;
            Wisdom = 1;
            Charisma = 1;
            HealthPoints = 100;
            ArmorClass = 10;
            Initiative = 1 + _rnd.Next(20);
            Speed = 30;
            Level = 1;
        }

        private readonly Random _rnd = new Random();

        public int Attack()
        {
            var maxDamage = _rnd.Next((int)(Strength - (Strength * .25)), Strength + Shortsword.Damage + 1);
            return _rnd.Next(maxDamage);
        }
    }
}
