using Inheritance.Interfaces;
using System;

namespace Inheritance.Models
{
    public class Rat : IBaseStats, IStatBlocks
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

        public Rat()
        {
            Name = "Rat";
            Strength = -4;
            Constitution = -1;
            Dexterity = 0;
            Intelligence = -4;
            Wisdom = 0;
            Charisma = -3;
            HealthPoints = Rnd.Next(2, 9) + 100;
            ArmorClass = 10;
            Initiative = 1 + Rnd.Next(20);
            Speed = 20;
            Level = 1;
        }

        public readonly Random Rnd = new Random();
        public int Attack()
        {
            var maxDamage = Rnd.Next(1, 3);
            return maxDamage;
        }
    }
}
