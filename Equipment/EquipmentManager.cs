using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : BaceEquipment
{
    public EquipmentManager(string Name, string id, string Desc, int agility, int strength, int wisdom, int defence, EquipmentTypes type, int spellEffectID)
    {
        name = Name;
        description = Desc;
        itemid = "item.equipment." + type.ToString().ToLower() + "." + id.ToLower();
        Agility = agility;
        Strength = strength;
        Wisdom = wisdom;
        Defence = defence;
        EquipmentType = type;
        SpellEffectID = spellEffectID;
    }
}
