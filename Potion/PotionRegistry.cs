using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionRegistry
{
    private static HPRegistry hp = new HPRegistry();
    private static MPRegistry mp = new MPRegistry();
    private static RestoreRegistry restore = new RestoreRegistry();
    private static List<PotionManager> hpList = new List<PotionManager>();
    private static List<PotionManager> mpList = new List<PotionManager>();
    private static List<PotionManager> restoreList = new List<PotionManager>();


    public static void print()
    {
        foreach (PotionManager pm in hpList)
        {
            Debug.Log("Registering Object With Name: " + pm.name + ", With ID: " + pm.itemid + ", And With The Type Identifier: " + pm.PotionType.ToString() + "\r\n Weapon Description: " + pm.description + "\r\n Is Important: " + pm.isImportantItem);
        }
        foreach (PotionManager pm in mpList)
        {
            Debug.Log("Registering Object With Name: " + pm.name + ", With ID: " + pm.itemid + ", And With The Type Identifier: " + pm.PotionType.ToString() + "\r\n Weapon Description: " + pm.description + "\r\n Is Important: " + pm.isImportantItem);
        }
        foreach (PotionManager pm in restoreList)
        {
            Debug.Log("Registering Object With Name: " + pm.name + ", With ID: " + pm.itemid + ", And With The Type Identifier: " + pm.PotionType.ToString() + "\r\n Weapon Description: " + pm.description + "\r\n Is Important: " + pm.isImportantItem);
        }
    }
    public static void init()
    {
        registerPotions();
        print();
    }

    public static void registerPotions()
    {
        //REGISTER HP
        hpList.Add(hp.healingPotion());
        hpList.Add(hp.megaPotion());
        hpList.Add(hp.superPotion());
        hpList.Add(hp.extremePotion());
        hpList.Add(hp.hyperPotion());
        hpList.Add(hp.fullPotion());
        //REGISTER MP
        mpList.Add(mp.magicPotion());
        mpList.Add(mp.wizardsElixer());
        //REGISTER RESTORE
        restoreList.Add(restore.restorePotion());
        restoreList.Add(restore.omniRestorePotion());
       
        //REGISTER AGILITY
        //-NO ITEMS REGISTERED
        //REGISTER STRENGTH
        //-NO ITEMS REGISTERED
        //REGISTER WISDOM
        //-NO ITEMS REGISTERED
        //REGISTER DEFENCE
        //-NO ITEMS REGISTERED
    }

    public class HPRegistry
    {
        public PotionManager healingPotion()
        {
            PotionManager pm = null;
            pm = new PotionManager("Healing Potion", "healing_potion", "This Potion Restores 20 HP To The User!", 0, 0, 0, 0, PotionBace.PotionTypes.HP, 0);
            return pm;
        }
        public PotionManager megaPotion()
        {
            PotionManager pm = null;
            pm = new PotionManager("Mega Potion", "mega_potion", "This Potion Restores 50 HP To The User!", 0, 0, 0, 0, PotionBace.PotionTypes.HP, 0);
            return pm;
        }
        public PotionManager superPotion()
        {
            PotionManager pm = null;
            pm = new PotionManager("Super Potion", "super_potion", "This Potion Restores 100 HP To The User!", 0, 0, 0, 0, PotionBace.PotionTypes.HP, 0);
            return pm;
        }
        public PotionManager extremePotion()
        {
            PotionManager pm = null;
            pm = new PotionManager("Extreme Potion", "extreme_potion", "This Potion Restores 150 HP To The User!", 0, 0, 0, 0, PotionBace.PotionTypes.HP, 0);
            return pm;
        }
        public PotionManager hyperPotion()
        {
            PotionManager pm = null;
            pm = new PotionManager("Hyper Potion", "hyper_potion", "This Potion Restores 225 HP To The User!", 0, 0, 0, 0, PotionBace.PotionTypes.HP, 0);
            return pm;
        } 
        public PotionManager fullPotion()
        {
            PotionManager pm = null;
            pm = new PotionManager("Full Potion", "full_potion", "This Potion Restores ALL HP To The User!", 0, 0, 0, 0, PotionBace.PotionTypes.HP, 0);
            return pm;
        }
    }
    public class MPRegistry
    {
        public PotionManager magicPotion()
        {
            PotionManager pm = null;
            pm = new PotionManager("Magic Potion", "magic_potion", "This Potion Restores 25 MP To The User!", 0, 0, 0, 0, PotionBace.PotionTypes.MP, 0);
            return pm;
        }
        public PotionManager wizardsElixer()
        {
            PotionManager pm = null;
            pm = new PotionManager("Wizards Elixer", "wizards_elixer", "This Potion Restores ALL MP To The User!", 0, 0, 0, 0, PotionBace.PotionTypes.MP, 0);
            return pm;
        }
    }
    public class RestoreRegistry
    {
        public PotionManager restorePotion()
        {
            PotionManager pm = null;
            pm = new PotionManager("Restore", "restore", "It Has A 50% Chance Restoring A Fallen Player, If Reserected Player Will Only Have HALF Health!", 0, 0, 0, 0, PotionBace.PotionTypes.RESTORE, 0);
            return pm;
        }
        public PotionManager omniRestorePotion()
        {
            PotionManager pm = null;
            pm = new PotionManager("Omni-Restore", "omnirestore", "It Restores A Fallen Player To Full Health!", 0, 0, 0, 0, PotionBace.PotionTypes.RESTORE, 0);
            return pm;
        }
    }
    public class AgilityRegistry
    {

    }
    public class StrengthRegistry
    {

    }
    public class WisdomRegistry
    {

    }
    public class DefenceRegistry
    {

    }
}
