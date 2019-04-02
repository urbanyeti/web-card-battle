using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
    public enum CardType
    {
        Attack,
        Skill,
        Power
    }
    public enum TargetType
    {
        single,
        multiple,
        all
    }

    public enum EffectType
    {
        Poison,
        Paralyze,
        Strong,
        Weak,
        Vulnerable,
        Armor,
        Dexterity,
        Heal
    }

    public enum QueryStatus
    {
        Found,
        OK,
        NotFound
    }
}
