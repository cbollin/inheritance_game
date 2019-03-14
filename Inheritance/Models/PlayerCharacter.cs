using System;
using Inheritance.Enums;
using Inheritance.Helper;
using Inheritance.Interfaces;

namespace Inheritance.Models
{
    internal class PlayerCharacter : Base
    {
        public PlayerCharacter(string name, BaseClass baseClass, Stat level, bool hasWeapon, WeaponClass item)
            : base(name, baseClass, item)
        {
            Level = level;
            Experience = 0;
            HasWeapon = hasWeapon;
        }
    }
}