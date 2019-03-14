using Inheritance.Enums;
using Inheritance.Models;

namespace Inheritance.Interfaces
{
    public interface IBase
    {
        string Name { get; set; }
        bool HasWeapon { get; set; }
        void Attack(IBase enemy, IBase player, IWeapon playerWeapon, IWeapon enemyWeapon);
        void TakeDamage(int damage);
        BaseClass Class { get; set; }
        WeaponClass Item { get; set; }
        Stat Strength { get; set; }
        Stat Constitution { get; set; }
        Stat Dexterity { get; set; }
        Stat Intelligence { get; set; }
        Stat Wisdom { get; set; }
        Stat Charisma { get; set; }
        Stat ArmorClass { get; set; }
        Stat Initiative { get; set; }
        Stat Speed { get; set; }
        Stat Level { get; set; }
        Stat HealthPoints { get; set; }
    }
}