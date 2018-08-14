using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionManager : PotionBace
{
     public PotionManager(string Name, string id, string Desc, int agility, int strength, int wisdom, int defence, PotionTypes type, int spellEffectID)
    {
        name = Name;
        description = Desc;
        itemid = "item.potion." + type.ToString().ToLower() + "." + id.ToLower();
        Agility = agility;
        Strength = strength;
        Wisdom = wisdom;
        Defence = defence;
        PotionType = type;
        SpellEffectID = spellEffectID;
    }
}
