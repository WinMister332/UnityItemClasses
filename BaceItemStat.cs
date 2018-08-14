using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaceItemStat : ItemBace
{
    private int _Agiliy;
    private int _Strength;
    private int _Wisdom;
    private int _Defence;

    //GETTERS + SETTERS
    public int Agility
    {
        get { return this._Agiliy; }
        set { _Agiliy = value; }
    }
    public int Strength
    {
        get { return this._Strength; }
        set { _Strength = value; }
    }
    public int Wisdom
    {
        get { return this._Wisdom; }
        set { _Wisdom = value; }
    }
    public int Defence
    {
        get { return this._Defence; }
        set { _Defence = value; }
    }
}
