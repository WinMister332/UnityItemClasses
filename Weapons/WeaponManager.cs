using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class WeaponManager : WeaponBace
{ 
    public WeaponManager(string Name, string id, string Desc, int agility, int strength, int wisdom, int defence, WeaponTypes type, int spellEffectID)
    {
        name = Name;
        description = Desc;
        itemid = "item.weapon." + type.ToString().ToLower() + "." + id.ToLower();
        Agility = agility;
        Strength = strength;
        Wisdom = wisdom;
        Defence = defence;
        WeaponType = type;
        SpellEffectID = SpellEffectID;
    }
}
