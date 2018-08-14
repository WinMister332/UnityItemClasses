using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBace
{
    private string _NAME;
    private string _DESC;
    private string _ITEMID;
    private bool _ISIMPORTANT;
    public enum ItemTypes
    {
        EQUIPMENT,
        WEAPON,
        POTION,
        CHEST,
        TELEPORT,
        REGULAR
		OTHER
    }

    public string name
    {
        get { return this._NAME; }
        set { _NAME = value; }
    }

    public string description
    {
        get { return this._DESC; }
        set { _DESC = value; }
    }

    public string itemid
    {
        get { return this._ITEMID; }
        set { _ITEMID = value; }
    }

    public bool isImportantItem
    {
        get { return this._ISIMPORTANT; }
        set { _ISIMPORTANT = value; }
    }

    private ItemTypes type;
    public ItemTypes Types
    {
        get { return type; }
        set { type = value; }
    }

}
