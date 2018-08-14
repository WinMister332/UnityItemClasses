using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRegistry
{
    private static SwordRegistry swords = new SwordRegistry();
    private static SpearRegistry spears = new SpearRegistry();
    private static KnifeRegistry knifes = new KnifeRegistry();
    private static BowRegistry bows = new BowRegistry();
    private static AxeRegistry axes = new AxeRegistry();
    private static BoomerangRegistry boomerangs = new BoomerangRegistry();
    private static HammerRegistry hammers = new HammerRegistry();
    private static StavesRegistry staves = new StavesRegistry();
    private static List<WeaponManager> swordList = new List<WeaponManager>();
    private static List<WeaponManager> spearList = new List<WeaponManager>();
    private static List<WeaponManager> knifeList = new List<WeaponManager>();
    private static List<WeaponManager> bowList = new List<WeaponManager>();
    private static List<WeaponManager> boomerangList = new List<WeaponManager>();
    private static List<WeaponManager> axeList = new List<WeaponManager>();
    private static List<WeaponManager> hammerList = new List<WeaponManager>();
    private static List<WeaponManager> stavesList = new List<WeaponManager>();

    public static void init()
    {
        registerWeapons();
        print();
    }

    private static void print()
    {
        foreach (WeaponManager wm in swordList)
        {
            Debug.Log("Registering Object With Name: " + wm.name + ", With ID: " + wm.itemid + ", And With The Type Identifier: " + wm.WeaponType.ToString() + "\r\n Weapon Description: " + wm.description + "\r\n Is Important: " + wm.isImportantItem);
        }
        foreach (WeaponManager wm in spearList)
        {
            Debug.Log("Registering Object With Name: " + wm.name + ", With ID: " + wm.itemid + ", And With The Type Identifier: " + wm.WeaponType.ToString() + "\r\n Weapon Description: " + wm.description + "\r\n Is Important: "+ wm.isImportantItem);
        }
        foreach (WeaponManager wm in knifeList)
        {
            Debug.Log("Registering Object With Name: " + wm.name + ", With ID: " + wm.itemid + ", And With The Type Identifier: " + wm.WeaponType.ToString() + "\r\n Weapon Description: " + wm.description + "\r\n Is Important: " + wm.isImportantItem);
        }
        foreach (WeaponManager wm in bowList)
        {
            Debug.Log("Registering Object With Name: " + wm.name + ", With ID: " + wm.itemid + ", And With The Type Identifier: " + wm.WeaponType.ToString() + "\r\n Weapon Description: " + wm.description + "\r\n Is Important: " + wm.isImportantItem);
        }
        foreach (WeaponManager wm in boomerangList)
        {
            Debug.Log("Registering Object With Name: " + wm.name + ", With ID: " + wm.itemid + ", And With The Type Identifier: " + wm.WeaponType.ToString() + "\r\n Weapon Description: " + wm.description + "\r\n Is Important: " + wm.isImportantItem);
        }
        foreach (WeaponManager wm in axeList)
        {
            Debug.Log("Registering Object With Name: " + wm.name + ", With ID: " + wm.itemid + ", And With The Type Identifier: " + wm.WeaponType.ToString() + "\r\n Weapon Description: " + wm.description + "\r\n Is Important: " + wm.isImportantItem);
        }
        foreach (WeaponManager wm in hammerList)
        {
            Debug.Log("Registering Object With Name: " + wm.name + ", With ID: " + wm.itemid + ", And With The Type Identifier: " + wm.WeaponType.ToString() + "\r\n Weapon Description: " + wm.description + "\r\n Is Important: " + wm.isImportantItem);
        }
        foreach (WeaponManager wm in stavesList)
        {
            Debug.Log("Registering Object With Name: " + wm.name + ", With ID: " + wm.itemid + ", And With The Type Identifier: " + wm.WeaponType.ToString() + "\r\n Weapon Description: " + wm.description + "\r\n Is Important: " + wm.isImportantItem);
        }
    }

    public static void registerWeapons()
    {
        //REGISTER SWORD
        swordList.Add(swords.trainingSword());
        swordList.Add(swords.soldiersSword());
        swordList.Add(swords.stoneSword());
        swordList.Add(swords.copperSword());
        swordList.Add(swords.steelBroadsword());
        swordList.Add(swords.rustyOldSword());
        swordList.Add(swords.undeadSword());
        swordList.Add(swords.undeadSlayer());
        swordList.Add(swords.snoozeBlade());
        swordList.Add(swords.platinumSword());
        swordList.Add(swords.dragonsBane());
        swordList.Add(swords.dragonSlayer());
        swordList.Add(swords.FreezerBlade());
        swordList.Add(swords.miracleBlade());
        //REGISTER SPEAR
        spearList.Add(spears.ironLance());
        spearList.Add(spears.longSpear());
        spearList.Add(spears.partizan());
        spearList.Add(spears.sandSpear());
        spearList.Add(spears.darkSpear());
        spearList.Add(spears.lightSpear());
        //REGISTER KNIFE
        knifeList.Add(knifes.bronzeKnife());
        knifeList.Add(knifes.dagger());
        knifeList.Add(knifes.falconKnife());
        knifeList.Add(knifes.assassinsDagger());
        knifeList.Add(knifes.birdKnife());
        knifeList.Add(knifes.suckerKnife());
        //REGISTER BOW
        bowList.Add(bows.shortBow());
        bowList.Add(bows.huntersBow());
        bowList.Add(bows.greatBow());
        bowList.Add(bows.mastersBow());
        //REGISTER BOOMERANG
        boomerangList.Add(boomerangs.boomerang());
        boomerangList.Add(boomerangs.edgedBoomerang());
        boomerangList.Add(boomerangs.razorBoomerang());
        boomerangList.Add(boomerangs.metalWingBoomerang());
        //REGISTER AXE
        axeList.Add(axes.stoneAxe());
        axeList.Add(axes.ironAxe());
        axeList.Add(axes.goldenAxe());
        axeList.Add(axes.battleAxe());
        axeList.Add(axes.robberAxe());
        axeList.Add(axes.moonAxe());
        axeList.Add(axes.kingsAxe());
        axeList.Add(axes.conqueresAxe());
        //REGISTER HAMMER
        hammerList.Add(hammers.woodenClub());
        hammerList.Add(hammers.giantMallet());
        hammerList.Add(hammers.sledgehammer());
        hammerList.Add(hammers.battleHammer());
        hammerList.Add(hammers.warHammer());
        hammerList.Add(hammers.megatonHammer());
        //REGISTER STAVES
        stavesList.Add(staves.woodenStaff());
        stavesList.Add(staves.thunderStaff());
        stavesList.Add(staves.antimagicStaff());
        stavesList.Add(staves.wizardsStaff());
    }

    public static List<WeaponManager> registeredSwords()
    {
        return swordList;
    }
    public static List<WeaponManager> registeredSpears()
    {
        return spearList;
    }
    public static List<WeaponManager> registeredKnifes()
    {
        return knifeList;
    }
    public static List<WeaponManager> registeredBows()
    {
        return bowList;
    }
    public static List<WeaponManager> registeredBoomerangs()
    {
        return boomerangList;
    }
    public static List<WeaponManager> registeredHammers()
    {
        return hammerList;
    }
    public static List<WeaponManager> registeredStaves()
    {
        return stavesList;
    }

    public class SpearRegistry
    {
        public WeaponManager ironLance()
        {
            WeaponManager wm;
            wm = new WeaponManager("Iron Lance", "iron_lance", "An Iron Spear Of The Kind Commonly Found Around The World!", 0, 1, 0, 0, WeaponBace.WeaponTypes.SPEAR, 0);
            return wm;
        }
        public WeaponManager longSpear()
        {
            WeaponManager wm;
            wm = new WeaponManager("Long Spear", "long_spear", "A Long Heavy Spear!", 0, 5, 0, 0, WeaponBace.WeaponTypes.SPEAR, 0);
            return wm;
        }
        public WeaponManager partizan()
        {
            WeaponManager wm;
            wm = new WeaponManager("Partizan", "partizan", "A Long Heavy Spear!", 0, 9, 0, 0, WeaponBace.WeaponTypes.SPEAR, 0);
            return wm;
        }
        public WeaponManager sandSpear()
        {
            WeaponManager wm;
            wm = new WeaponManager("Sand Spear", "sand_spear", "A Long Heavy Spear!", 0, 13, 0, 0, WeaponBace.WeaponTypes.SPEAR, 0);
            return wm;
        }
        public WeaponManager darkSpear()
        {
            WeaponManager wm;
            wm = new WeaponManager("Dark Spear", "dark_spear", "A Spear That Kills Instantly If It Hits Its Enemy's Vitals!", 0, 17, 0, 0, WeaponBace.WeaponTypes.SPEAR, 0);
            return wm;
        }
        public WeaponManager lightSpear()
        {
            WeaponManager wm;
            wm = new WeaponManager("Light Spear", "dark_spear", "A Spear That Restores Some Of The Users HP When Used In Combat!", 0, 17, 0, 0, WeaponBace.WeaponTypes.SPEAR, 0);
            return wm;
        }
    }

    public class SwordRegistry
    {
        public WeaponManager trainingSword()
        {
            WeaponManager wm;
            wm = new WeaponManager("Training Sword", "training_sword", "A Simple Wooden Sword Meant For Beginers In Swordsmanship!", 0, 1, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager soldiersSword()
        {
            WeaponManager wm;
            wm = new WeaponManager("Soldiers Sword", "soldiers_sword", "A Cheap Sword Given To Royal Guardsman At Kosmoanar Castle!", 0, 3, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager stoneSword()
        {
            WeaponManager wm;
            wm = new WeaponManager("Stone Sword", "stone_sword", "A Rather Dull Looking Sword Hand Crafted From Stone!", 0, 6, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager copperSword()
        {
            WeaponManager wm;
            wm = new WeaponManager("Copper Sword", "copper_sword", "A Widely Used Sword Made From Copper!", 0, 9, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager steelBroadsword()
        {
            WeaponManager wm;
            wm = new WeaponManager("Steel Broadsword", "steel_broadsword", "A Sturdy Sword Made From Forged Steel!", 0, 14, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager rustyOldSword()
        {
            WeaponManager wm;
            wm = new WeaponManager("Rusty Old Sword", "rusty_old_sword", "Once A Powerful Legend, Now Just A Rusty And Chipped Old Sword!", 0, 16, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager undeadSword()
        {
            WeaponManager wm;
            wm = new WeaponManager("Undead Sword", "undead_sword", "A Sword Created For Slaying Zombies And Most Undead Monsters!", 0, 20, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager undeadSlayer()
        {
            WeaponManager wm;
            wm = new WeaponManager("Undead Slayer", "undead_slayer", "An Improved Version Of The Undead Sword That Can Slay Any Undead Monsters!", 0, 25, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager snoozeBlade()
        {
            WeaponManager wm;
            wm = new WeaponManager("Snooze Blade", "snooze_blade", "A Magical Sword That Has A Chance Of Putting The Target Into A Deep Sleep!", 0, 28, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager platinumSword()
        {
            WeaponManager wm;
            wm = new WeaponManager("Platinum Sword", "platinum_sword", "A Beautifully Sharp Sword Forged From Pure Platinum!", 0, 37, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager dragonsBane()
        {
            WeaponManager wm;
            wm = new WeaponManager("Dragons Blade", "dragons_blade", "A Sharp Sword Capable Of Slicing Through Dragon Scales!", 0,42, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager dragonSlayer()
        {
            WeaponManager wm;
            wm = new WeaponManager("Dragons Slayer", "dragons_slayer", "A Improved Version Of Dragons Blade Which Is Capable Of Instanty Slaying Any Dragon!", 0, 48, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager FreezerBlade()
        {
            WeaponManager wm;
            wm = new WeaponManager("Freezer Blade", "freezer_blade", "A Magic Sword That Is Colder Then Ice!", 0, 55, 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }

        public WeaponManager miracleBlade()
        {
            WeaponManager wm;
            wm = new WeaponManager("Miracle Blade", "miracle_blade", "A Blade The Retores The User Upon Being Killed!", 0, 60 , 0, 0, WeaponBace.WeaponTypes.SWORD, 0);
            return wm;
        }
    }

    public class KnifeRegistry
    {
        public WeaponManager bronzeKnife()
        {
            WeaponManager wm;
            wm = new WeaponManager("Bronze Knife", "bronze_knife", "A Small Knife Forged From Bronze!", 0, 4, 0, 0, WeaponBace.WeaponTypes.KNIFE, 0);
            return wm;
        }
        public WeaponManager dagger()
        {
            WeaponManager wm;
            wm = new WeaponManager("Dagger", "dagger", "A Long Bladed Knife Designed To Be Used In Combat!", 0, 9, 0, 0, WeaponBace.WeaponTypes.KNIFE, 0);
            return wm;
        }
        public WeaponManager falconKnife()
        {
            WeaponManager wm;
            wm = new WeaponManager("Falcon Knife", "falcon_knife", "A Small Blade That Allows The User To Attack Twice!", 0, 17, 0, 0, WeaponBace.WeaponTypes.KNIFE, 0);
            return wm;
        }
        public WeaponManager assassinsDagger()
        {
            WeaponManager wm;
            wm = new WeaponManager("Assassins Dagger","assassins_dagger", "A Compact Knife Designed And Used Mostly By Assassins!", 0, 23, 0, 0, WeaponBace.WeaponTypes.KNIFE, 0);
            return wm;
        }
        public WeaponManager birdKnife()
        {
            WeaponManager wm;
            wm = new WeaponManager("Bird Knife", "bird_knife", "A Knife As Sharp A Birds Beak!", 0, 28, 0, 0, WeaponBace.WeaponTypes.KNIFE, 0);
            return wm;
        }
        public WeaponManager suckerKnife()
        {
            WeaponManager wm;
            wm = new WeaponManager("Sucker Knife", "sucker_knife", "A Knife That Will Steal Some Magic From The Target!", 0, 30, 0, 0, WeaponBace.WeaponTypes.KNIFE, 0);
            return wm;
        }
    }

    public class BowRegistry
    {
        public WeaponManager shortBow()
        {
            WeaponManager wm;
            wm = new WeaponManager("Short Bow", "short_bow", "A Small Lightweight Bow Meant For Novice Archers!", 0, 6, 0, 0, WeaponBace.WeaponTypes.BOW, 0);
            return wm;
        }
        public WeaponManager huntersBow()
        {
            WeaponManager wm;
            wm = new WeaponManager("Hunters Bow", "hunters_bow", "A Standered Bow, Popular Among Adventurers For Its Blend Of Power And Convenience!", 0, 10, 0, 0, WeaponBace.WeaponTypes.BOW, 0);
            return wm;
        }
        public WeaponManager greatBow()
        {
            WeaponManager wm;
            wm = new WeaponManager("Great Bow", "great_bow", "An Enormous Bow Designed To Fire Special Arrows With Tremendous Force!", 0, 15, 0, 0, WeaponBace.WeaponTypes.BOW, 0);
            return wm;
        }
        public WeaponManager mastersBow()
        {
            WeaponManager wm;
            wm = new WeaponManager("Masters Bow", "masters_bow", "A Special Bow For Skilled Archers!", 0, 20, 0, 0, WeaponBace.WeaponTypes.BOW, 0);
            return wm;
        }
    }
    
    public class BoomerangRegistry
    {
        public WeaponManager boomerang()
        {
            WeaponManager wm;
            wm = new WeaponManager("Boomerang", "boomerang", "A Throwing Weapon Capable Of Hitting Mutiple Enemy's At Once!", 0, 1, 0, 0, WeaponBace.WeaponTypes.BOOMERANG, 0);
            return wm;
        }
        public WeaponManager edgedBoomerang()
        {
            WeaponManager wm;
            wm = new WeaponManager("Edged Boomerang", "edged_boomerang", "A Metal Boomerang With Knife-Like Edges!", 0, 8, 0, 0, WeaponBace.WeaponTypes.BOOMERANG, 0);
            return wm;
        }
        public WeaponManager razorBoomerang()
        {
            WeaponManager wm;
            wm = new WeaponManager("Razor Boomerang", "razor_boomerang", "A Metal Boomerang That Is Sharper Then A Razor!", 0, 13, 0, 0, WeaponBace.WeaponTypes.BOOMERANG, 0);
            return wm;
        }
        public WeaponManager metalWingBoomerang()
        {
            WeaponManager wm;
            wm = new WeaponManager("Metal Wing Boomerang", "metal_wing_boomerang", "A Boomerang Designed For Peircing Through Metal Armor!", 0, 16, 0, 0, WeaponBace.WeaponTypes.BOOMERANG, 0);
            return wm;
        }
    }

    public class AxeRegistry
    {
        public WeaponManager stoneAxe()
        {
            WeaponManager wm;
            wm = new WeaponManager("Stone Axe", "stone_axe", "A Primitive Axe Sold In Almost Every Equipment Shop!", 0, 1, 0, 0, WeaponBace.WeaponTypes.AXE, 0);
            return wm;
        }
        public WeaponManager ironAxe()
        {
            WeaponManager wm;
            wm = new WeaponManager("Iron Axe", "iron_axe", "A Thick Sturdy Axe With A Cast Iron Head!", 0, 7, 0, 0, WeaponBace.WeaponTypes.AXE, 0);
            return wm;
        }
        public WeaponManager goldenAxe()
        {
            WeaponManager wm;
            wm = new WeaponManager("Golden Axe", "golden_axe", "A Dull Bladed Axe Forged From Pure Gold!", 0, 12, 0, 0, WeaponBace.WeaponTypes.AXE, 0);
            return wm;
        }
        public WeaponManager battleAxe()
        {
            WeaponManager wm;
            wm = new WeaponManager("Battle Axe", "battle_axe", "A Large Heavy Axe Designed For Combat!", 0, 18, 0, 0, WeaponBace.WeaponTypes.AXE, 0);
            return wm;
        }
        public WeaponManager robberAxe()
        {
            WeaponManager wm;
            wm = new WeaponManager("Robber Axe", "robber_axe", "An Axe That Was Designed And Used By A Famous Robber!", 0, 23, 0, 0, WeaponBace.WeaponTypes.AXE, 0);
            return wm;
        }
        public WeaponManager moonAxe()
        {
            WeaponManager wm;
            wm = new WeaponManager("Moon Axe", "moon_axe", "A Shiney Axe Which Is Brighter Then The Moon!", 0, 26, 0, 0, WeaponBace.WeaponTypes.AXE, 0);
            return wm;
        }
        public WeaponManager kingsAxe()
        {
            WeaponManager wm;
            wm = new WeaponManager("Kings Axe", "kings_axe", "A Large Axe That Was Once Used By A Very Powerful King!", 0, 30, 0, 0, WeaponBace.WeaponTypes.AXE, 0);
            return wm;
        }
        public WeaponManager conqueresAxe()
        {
            WeaponManager wm;
            wm = new WeaponManager("Conqueres Axe", "conqueres_axe", "A Powerful Axe That Was Used By A Conquerer!", 0, 36, 0, 0, WeaponBace.WeaponTypes.AXE, 0);
            return wm;
        }
    }

    public class HammerRegistry
    {
        public WeaponManager woodenClub()
        {
            WeaponManager wm;
            wm = new WeaponManager("Wooden Club", "wooden_club", "A Simple Club Made From Wood!", 0, 5, 0, 0, WeaponBace.WeaponTypes.HAMMER, 0);
            return wm;
        }
        public WeaponManager giantMallet()
        {
            WeaponManager wm;
            wm = new WeaponManager("Giant Mallet", "giant_mallet", "A Giant Mallet That Us Usually Carried By Both Monsters And Humans!", 0, 10, 0, 0, WeaponBace.WeaponTypes.HAMMER, 0);
            return wm;
        }
        public WeaponManager sledgehammer()
        {
            WeaponManager wm;
            wm = new WeaponManager("Sledgehammer", "sledgehammer", "A Massaive Hammer Made Of Iron", 0, 17, 0, 0, WeaponBace.WeaponTypes.HAMMER, 0);
            return wm;
        }
        public WeaponManager battleHammer()
        {
            WeaponManager wm;
            wm = new WeaponManager("Battle Hammer", "battle_hammer", "A Special Steel Hammer Made For Combat!", 0, 23, 0, 0, WeaponBace.WeaponTypes.HAMMER, 0);
            return wm;
        }
        public WeaponManager warHammer()
        {
            WeaponManager wm;
            wm = new WeaponManager("War Hammer", "war_hammer", "The Advanced Version Of The Battle Hammer!", 0, 26, 0, 0, WeaponBace.WeaponTypes.HAMMER, 0);
            return wm;
        }
        public WeaponManager megatonHammer()
        {
            WeaponManager wm;
            wm = new WeaponManager("Megaton Hammer", "megaton_hammer", "A Massive Hammer That Weighs A Ton!", 0, 31, 0, 0, WeaponBace.WeaponTypes.HAMMER, 0);
            return wm;
        }
    }

    public class StavesRegistry
    {
        public WeaponManager woodenStaff()
        {
            WeaponManager wm;
            wm = new WeaponManager("Wooden Staff", "wooden_staff", "A Lightweight Staff Made From Wood!", 0, 8, 0, 0, WeaponBace.WeaponTypes.STAVES, 0);
            return wm;
        }
        public WeaponManager thunderStaff()
        {
            WeaponManager wm;
            wm = new WeaponManager("Thunder Staff", "thunder_staff", "A Staff That Violently Zaps The Target With A Blinding Force Of Thunder!", 0, 16, 0, 0, WeaponBace.WeaponTypes.STAVES, 0);
            return wm;
        }
        public WeaponManager antimagicStaff()
        {
            WeaponManager wm;
            wm = new WeaponManager("Staff Of Antimagic", "antimagic_staff" , "A Staff When Used As An Item Will Block Enemy's From Casting Magic For At Least Two Turns!", 0, 22, 0, 0, WeaponBace.WeaponTypes.STAVES, 0);
            return wm;
        }
        public WeaponManager wizardsStaff()
        {
            WeaponManager wm;
            wm = new WeaponManager("Wizards Staff", "wizards_staff", "A Staff That Will Mutiply The User Magic If Equiped By A Wizard!", 0, 28, 0, 0, WeaponBace.WeaponTypes.STAVES, 0);
            return wm;
        }
    }
}
