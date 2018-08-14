using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionBace : BaceItemStat
{
    public enum PotionTypes
    {
        HP,
        MP,
        RESTORE,
        AGILITY,
        STRENGTH,
        WISDOM,
        DEFENCE
    }

    private int spellEffectID;

    private PotionTypes potionTypes;
    public PotionTypes PotionType
    {
        get { return potionTypes; }
        set { potionTypes = value;  }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
