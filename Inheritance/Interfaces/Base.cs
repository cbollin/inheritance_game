using System.Collections.Generic;

namespace Inheritance.Interfaces
{
    public interface IBaseStats
    {
        int Strength { get; set; }
        int Constitution { get; set; }
        int Dexterity { get; set; }
        int Intelligence { get; set; }
        int Wisdom { get; set; }
        int Charisma { get; set; }
    }

    public interface IStatBlocks
    {
        string Name { get; set; }
        int HealthPoints { get; set; }
        int ArmorClass { get; set; }
        int Initiative { get; set; }
        int Speed { get; set; }
        int Level { get; set; }
    }

    public interface IWeapons
    {
        string Name { get; set; }
        string Type { get; set; }
        string Category { get; set; }
        int Damage { get; set; }
        string DamageType { get; set; }
        string ItemRarity { get; set; }
        List<string> Properties { get; set; }
        int Weight { get; set; }
        decimal Cost { get; set; }
    }

    public interface IParty
    {
        int Size { get; set; }
        int Level { get; set; }
    }
}