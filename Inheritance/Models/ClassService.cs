using System;
using Inheritance.Enums;
using Inheritance.Interfaces;

namespace Inheritance.Models
{
    public static class ClassService
    {
        public static IBase GetBase(string name, BaseClass baseClass, bool hasWeapon, Stat level, WeaponClass item)
        {
            var character = new PlayerCharacter(name, baseClass, level, hasWeapon, item);

            switch (baseClass)
            {
                case BaseClass.Barbarian:
                    character.HealthPoints.Base = 13;
                    character.HealthPoints.Current = 13;
                    character.Strength.Current = 16;
                    character.Constitution.Current = 15;
                    character.Dexterity.Current = 14;
                    character.Intelligence.Current = 11;
                    character.Wisdom.Current = 13;
                    character.Charisma.Current = 9;
                    character.Initiative.Current = 2;
                    character.Speed.Current = 30;
                    break;
                case BaseClass.Cleric:
                    character.HealthPoints.Base = 10;
                    character.HealthPoints.Current = 10;
                    character.Strength.Current = 14;
                    character.Constitution.Current = 15;
                    character.Dexterity.Current = 9;
                    character.Intelligence.Current = 11;
                    character.Wisdom.Current = 16;
                    character.Charisma.Current = 13;
                    character.Initiative.Current = 5;
                    character.Speed.Current = 30;
                    break;
                case BaseClass.Bard:
                    break;
                case BaseClass.Druid:
                    break;
                case BaseClass.Fighter:
                    break;
                case BaseClass.Monk:
                    break;
                case BaseClass.Paladin:
                    break;
                case BaseClass.Ranger:
                    break;
                case BaseClass.Rogue:
                    break;
                case BaseClass.Sorcerer:
                    break;
                case BaseClass.Warlock:
                    break;
                case BaseClass.Wizard:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(baseClass), baseClass, null);
            }
            return character;
        }
    }
}