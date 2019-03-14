using System;
using Inheritance.Enums;
using Inheritance.Helper;
using Inheritance.Interfaces;

namespace Inheritance.Models
{
    public class Base : IBase
    {
        public string Name { get; set; }
        public bool HasWeapon { get; set; }
        public BaseClass Class { get; set; }
        public WeaponClass Item { get; set; }
        public Stat Strength { get; set; }
        public Stat Constitution { get; set; }
        public Stat Dexterity { get; set; }
        public Stat Intelligence { get; set; }
        public Stat Wisdom { get; set; }
        public Stat Charisma { get; set; }
        public Stat ArmorClass { get; set; }
        public Stat Initiative { get; set; }
        public Stat Speed { get; set; }
        public Stat Level { get; set; }
        public Stat HealthPoints { get; set; }
        public int Experience { get; set; }
        public Base(string name, BaseClass baseClass, WeaponClass item)
        {
            Name = name;
            Class = baseClass;
            Item = item;
            Strength = new Stat();
            Constitution = new Stat();
            Dexterity = new Stat();
            Intelligence = new Stat();
            Wisdom = new Stat();
            Charisma = new Stat();
            ArmorClass = new Stat();
            Initiative = new Stat();
            Speed = new Stat();
            Level = Level;
            HealthPoints = new Stat();
        }
        //if the player has a weapon, increase the damage dealt based on that weapon damage
        public virtual void Attack(IBase enemy, IBase player, IWeapon playerWeapon, IWeapon enemyWeapon)
        {
            if (enemy.Initiative.Current > player.Initiative.Current)
            {
                player.TakeDamage(enemyWeapon.Damage.Current);
                Console.WriteLine($"{enemy.Name} uses their {enemyWeapon.Name} to deal {enemyWeapon.Damage.Current} {enemyWeapon.DamageType} damage.");
            }
            else if(player.Initiative.Current >= enemy.Initiative.Current)
            {
                enemy.TakeDamage(playerWeapon.Damage.Current);
                Console.WriteLine($"{player.Name} uses their {playerWeapon.Name} to deal {playerWeapon.Damage.Current} {playerWeapon.DamageType} damage.");
            }
        }

        public void TakeDamage(int damage)
        {
            HealthPoints.Current -= damage;
            if (HealthPoints.Current < 1)
            {
                HealthPoints.Current = 0;
            }
        }
    }
}