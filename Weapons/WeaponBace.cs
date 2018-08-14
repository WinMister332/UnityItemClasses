using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBace : BaceItemStat
{
    public enum WeaponTypes
    {
        SPEAR,
        SWORD,
        KNIFE,
        BOW,
        BOOMERANG,
        AXE,
        HAMMER,
        STAVES
    }

    private int spellEffectID;

    private WeaponTypes weaponType;
    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }

}
