using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaceEquipment : BaceItemStat
{
    public enum EquipmentTypes
    {
        ARMOUR,
        SHIELD,
        HELMETS,
        ACCESSORIES_RING,
        //ACCESSORIES_EARRING,
        ACCESSORIES_FOOTWEAR,
        ACCESSORIES_NECKLACE,
        ACCESSORIES_BRACELET, 
        ACCESSORIES_MISC
    }

    private EquipmentTypes equipmentTypes;
    private int spellEffectID;

    public EquipmentTypes EquipmentType
    {
        get { return equipmentTypes; }
        set { equipmentTypes = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }

}
