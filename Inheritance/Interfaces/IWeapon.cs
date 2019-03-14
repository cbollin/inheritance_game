using System.Collections.Generic;
using Inheritance.Models;

namespace Inheritance.Interfaces
{
    public interface IWeapon
    {
        string Name { get; set; }
        string Type { get; set; }
        string Category { get; set; }
        Stat Damage { get; set; }
        string DamageType { get; set; }
        string ItemRarity { get; set; }
        List<string> Properties { get; set; }
        int Weight { get; set; }
        decimal Cost { get; set; }
    }
}