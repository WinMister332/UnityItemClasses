using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentRegistry
{
    private static ArmourRegistry armour = new ArmourRegistry();
    private static ShieldRegistry shield = new ShieldRegistry();
    private static HelmetRegistry helmet = new HelmetRegistry();
    private static Accessory_RingRegistry ring = new Accessory_RingRegistry();
    private static Accessory_FootwearRegistry footwear = new Accessory_FootwearRegistry();
    private static Accessory_NecklaceRegistry necklace = new Accessory_NecklaceRegistry();
    private static Accessory_BraceletRegistry bracelet = new Accessory_BraceletRegistry();
    private static Accessory_MiscRegistry misc = new Accessory_MiscRegistry();
    private static List<EquipmentManager> armourList = new List<EquipmentManager>();
    private static List<EquipmentManager> shieldList = new List<EquipmentManager>();
    private static List<EquipmentManager> helmetList = new List<EquipmentManager>();
    private static List<EquipmentManager> ringList = new List<EquipmentManager>();
    private static List<EquipmentManager> footwearList = new List<EquipmentManager>();
    private static List<EquipmentManager> necklaceList = new List<EquipmentManager>();
    private static List<EquipmentManager> braceletList = new List<EquipmentManager>();
    private static List<EquipmentManager> miscList = new List<EquipmentManager>();

    private static void print()
    {
        foreach (EquipmentManager em in armourList)
        {
            Debug.Log("Registering Object With Name: " + em.name + ", With ID: " + em.itemid + ", And With The Type Identifier: " + em.EquipmentType.ToString() + "\r\n Weapon Description: " + em.description + "\r\n Is Important: " + em.isImportantItem);
        }
        foreach (EquipmentManager em in shieldList)
        {
            Debug.Log("Registering Object With Name: " + em.name + ", With ID: " + em.itemid + ", And With The Type Identifier: " + em.EquipmentType.ToString() + "\r\n Weapon Description: " + em.description + "\r\n Is Important: " + em.isImportantItem);
        }
        foreach (EquipmentManager em in helmetList)
        {
            Debug.Log("Registering Object With Name: " + em.name + ", With ID: " + em.itemid + ", And With The Type Identifier: " + em.EquipmentType.ToString() + "\r\n Weapon Description: " + em.description + "\r\n Is Important: " + em.isImportantItem);
        }
        foreach (EquipmentManager em in ringList)
        {
            Debug.Log("Registering Object With Name: " + em.name + ", With ID: " + em.itemid + ", And With The Type Identifier: " + em.EquipmentType.ToString() + "\r\n Weapon Description: " + em.description + "\r\n Is Important: " + em.isImportantItem);
        }
        foreach (EquipmentManager em in footwearList)
        {
            Debug.Log("Registering Object With Name: " + em.name + ", With ID: " + em.itemid + ", And With The Type Identifier: " + em.EquipmentType.ToString() + "\r\n Weapon Description: " + em.description + "\r\n Is Important: " + em.isImportantItem);
        }
        foreach (EquipmentManager em in necklaceList)
        {
            Debug.Log("Registering Object With Name: " + em.name + ", With ID: " + em.itemid + ", And With The Type Identifier: " + em.EquipmentType.ToString() + "\r\n Weapon Description: " + em.description + "\r\n Is Important: " + em.isImportantItem);
        }
        foreach (EquipmentManager em in braceletList)
        {
            Debug.Log("Registering Object With Name: " + em.name + ", With ID: " + em.itemid + ", And With The Type Identifier: " + em.EquipmentType.ToString() + "\r\n Weapon Description: " + em.description + "\r\n Is Important: " + em.isImportantItem);
        }
        foreach (EquipmentManager em in miscList)
        {
            Debug.Log("Registering Object With Name: " + em.name + ", With ID: " + em.itemid + ", And With The Type Identifier: " + em.EquipmentType.ToString() + "\r\n Weapon Description: " + em.description + "\r\n Is Important: " + em.isImportantItem);
        }
    }

    public static void init()
    {
        registerEquipment();
        print();
    }

    public static void registerEquipment()
    {
        //REGISTER ARMOUR
        armourList.Add(armour.plainClothes());
        armourList.Add(armour.burgulersClothes());
        armourList.Add(armour.peasentsCloak());
        armourList.Add(armour.leatherPants());
        armourList.Add(armour.leatherShirt());
        armourList.Add(armour.leatherSuit());
        armourList.Add(armour.dragonScaleArmour());
        armourList.Add(armour.chainMail());
        armourList.Add(armour.bronzeArmour());
        armourList.Add(armour.ironArmour());
        armourList.Add(armour.goldArmour());
        armourList.Add(armour.turtleShell());
        armourList.Add(armour.fullBodyArmour());
        armourList.Add(armour.silverMail());
        armourList.Add(armour.dragonMail());
        armourList.Add(armour.velvetRobe());
        armourList.Add(armour.platinumMail());
        armourList.Add(armour.legendsRobe());
        armourList.Add(armour.wizardRobe());
        armourList.Add(armour.fursuit());
        //REGISTER SHIELD
        shieldList.Add(shield.basicShield());
        shieldList.Add(shield.woodenShield());
        shieldList.Add(shield.scaleShield());
        shieldList.Add(shield.bronzeShield());
        shieldList.Add(shield.ironShield());
        shieldList.Add(shield.steelShield());
        shieldList.Add(shield.silverShield());
        //REGISTER HELMET
        helmetList.Add(helmet.leatherHat());
        helmetList.Add(helmet.stoneHardhat());
        helmetList.Add(helmet.ironHelm());
        helmetList.Add(helmet.fallenKingCrown());
        helmetList.Add(helmet.ironMask());
        helmetList.Add(helmet.platinumHeadgear());
        helmetList.Add(helmet.scholarsCap());
        helmetList.Add(helmet.hatOfDistraction());
        helmetList.Add(helmet.thinkingCap());
        helmetList.Add(helmet.leadersHelm());
        helmetList.Add(helmet.moonCrown());
        helmetList.Add(helmet.furryHead());
        //REGISTER RING
        ringList.Add(ring.bronzeRing());
        ringList.Add(ring.ironRing());
        ringList.Add(ring.goldRing());
        ringList.Add(ring.silverRing());
        ringList.Add(ring.ringOfMagic());
        ringList.Add(ring.healersRing());
        //REGISTER FOOTWEAR
        footwearList.Add(footwear.leatherBoots());
        footwearList.Add(footwear.hindPaws());
        //REGISTER NECKLACE
        necklaceList.Add(necklace.goldNecklace());
        necklaceList.Add(necklace.collar());
        //REGISTER BRACELET
        braceletList.Add(bracelet.goldenBracelet());
        braceletList.Add(bracelet.forePaws());
        //REGISTER MISC
        miscList.Add(misc.pawStraps());
    }

    public class ArmourRegistry
    {
        public EquipmentManager plainClothes()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Plain Clothes", "plain_clothes", "An Unremarkable Garment Made Entirly From Cotton!", 0, 0, 0 ,2, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager burgulersClothes()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Burgulers Clothes", "burgulers_clothes", "A Unreliable Outfit Made For Burgulers!", 0, 0, 0, 4, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager peasentsCloak()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Peasents Cloak", "peasents_cloak", "A Cloak That Is Worn Primarally By Peasents!", 0, 0, 0, 8, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager leatherPants()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Leather Pants", "leather_pants", "Lightweight Pants Made From A Sturdy Leather!", 0, 0, 0, 12, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager leatherShirt()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Leather Shirt", "leather_shirt", "Lightweight Shirt Made From A Sturdy Leather!", 0, 0, 0, 14, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager leatherSuit()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Leather Suit", "leather_suit", "Lightweight Suit Made From A Sturdy Leather!", 0, 0, 0, 16, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager dragonScaleArmour()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Dragonscale Armour", "dragonscale_armour", "Heavy Sturdy Armour Made From Dragon Scales!", 0, 0, 0, 24, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager chainMail()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Chainmail", "chain_mail", "A Comfortible And Lightweight Suit Of Armour Constructed From Unbreakable Metal Links!", 0, 0, 0, 28, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager bronzeArmour()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Bronze Armour", "bronze_armour", "A Suit Of Armour Made From Pure Bronze Plates!", 0, 0, 0, 31, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager ironArmour()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Iron Armour", "iron_armour", "A Upgraded Version Of Bronze Armour Which Is Forged From Iron!", 0, 0, 0, 37, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager goldArmour()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Gold Armour", "gold_armour", "An Upgraded Version Of Iron Armour Which Is Forged From Pure Gold!", 0, 0, 0, 45, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager turtleShell()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Turtle Shell", "turtle_shell", "A Turtle Shell Taken From A Human Sized Turtle!", 0, 0, 0, 43, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager fullBodyArmour()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Full-Body Armour", "full_body_armour", "A Stainless Steel Armour That Covers The Entire Body!", - 8, 0, 0, 48, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager silverMail()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Silver Mail", "silver_mail", "A Shiney Armour Made From Silver!", - 10, 0, 0, 53, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager dragonMail()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Dragon Mail", "dragon_mail", "Armour Made From Dragon Scales!", 0, 0, 0, 58, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager velvetRobe()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Velvet Robe", "velvet_robe", "A Robe Made From A Pure Velvet Cloth!", 10, 0, 0, 60, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager platinumMail()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Platinum Mail", "platinum_mail", "An Upgrade Of Silver Mail Made From Pure Platinum!", 0, 0, 0, 66, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager legendsRobe()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Legends Robe", "legends_robe", "A Thin Robe Worn By Legends!", 0, 0, 0, 70, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager wizardRobe()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Wizards Robe", "wizard_robe", "A Robe When Whorn By Wizards Doubles The Wearers Magic!", 0, 0, 0, 75, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            return em;
        }
        public EquipmentManager fursuit()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Fursuit", "fursuit", "A Special Suit Worn By Humans That Like To Be Animals!", -8, 0, 0, 88, BaceEquipment.EquipmentTypes.ARMOUR, 0);
            em.isImportantItem = true;
            return em;
        }
    }
    public class ShieldRegistry
    {
        public EquipmentManager basicShield()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Basic Shield", "basic_shield", "A Super Basic Leather Shield Made With A Super Thin Wooden Frame!", 0, 0, 0, 2, BaceEquipment.EquipmentTypes.SHIELD, 0);
            return em;
        }
        public EquipmentManager woodenShield()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Wooden Shield", "wooden_shield", "A Shield Made From Wood!", 0, 0, 0, 5, BaceEquipment.EquipmentTypes.SHIELD, 0);
            return em;
        }
        public EquipmentManager scaleShield()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Scale Shield", "scale_shield", "A Sturdy Shield Made From Scales Taken From Small Reptiles!", 0, 0, 0, 8, BaceEquipment.EquipmentTypes.SHIELD, 0);
            return em;
        }
        public EquipmentManager bronzeShield()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Bronze Shield", "bronze_shield", "A Sturdy Lightweight Shield Made From A Bronze Metal!", 0, 0, 0, 11, BaceEquipment.EquipmentTypes.SHIELD, 0);
            return em;
        }
        public EquipmentManager ironShield()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Iron Shield", "iron_shield", "An Upgraded Version Of The Bronze Shield Made From Iron!", 0, 0, 0, 14, BaceEquipment.EquipmentTypes.SHIELD, 0);
            return em;
        }
        public EquipmentManager steelShield()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Steel Shield", "steel_shield", "A Shield Made From Stainless Steel!", 0, 0, 0, 17, BaceEquipment.EquipmentTypes.SHIELD, 0);
            return em;
        }
        public EquipmentManager silverShield()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Silver Shield", "silver_shield", "An Upgraded Version Of The Steel Shield Which Was Made From A Shiney Silver Metal!", 0, 0, 0, 20, BaceEquipment.EquipmentTypes.SHIELD, 0);
            return em;
        }
    }
    public class HelmetRegistry
    {
        public EquipmentManager leatherHat()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Leather Hat", "lether_hat", "A Hat Made From A Strong Leather!", 0, 0, 0, 3, BaceEquipment.EquipmentTypes.HELMETS, 0);
            return em;
        }
        public EquipmentManager stoneHardhat()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Stone Hardhat", "stone_hardhat", "A Light And Very Hard Hat Made From Stone!", 0, 0, 0, 5, BaceEquipment.EquipmentTypes.HELMETS, 0);
            return em;
        }
        public EquipmentManager ironHelm()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Iron Help", "iron_helm", "A Light Helmet Made From Iron!", 0, 0, 0, 7, BaceEquipment.EquipmentTypes.HELMETS, 0);
            return em;
        }
        public EquipmentManager fallenKingCrown()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Fallen King Crown", "fallen_king_crown", "A Crown Once Worn By A King Who Has Died In Battle!", 0, 0, 0, 9, BaceEquipment.EquipmentTypes.HELMETS, 0);
            return em;
        }
        public EquipmentManager ironMask()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Iron Mask", "iron_mask", "An Iron Mask That Covers The Wearers Entire Face!", 0, 0, 0, 11, BaceEquipment.EquipmentTypes.HELMETS, 0);
            return em;
        }
        public EquipmentManager platinumHeadgear()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Platinum Headgear", "platinum_headgear", "A Whole Head Covering That Is Forged From Pure Platinum!", 0, 0, 0, 13, BaceEquipment.EquipmentTypes.HELMETS, 0);
            return em;
        }
        public EquipmentManager scholarsCap()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Scholars Cap", "scholars_cap", "A Cap That Will Increase The Wearers Wisdom!", 0, 0, 10, 0, BaceEquipment.EquipmentTypes.HELMETS, 0);
            return em;
        }
        public EquipmentManager hatOfDistraction()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Hat Of Distraction", "hat_of_distraction", "A Hat That Allows The Wearer To Move So Fast It May Leave The Enemy Distracted In Battle!", 0, 0, 0, 15, BaceEquipment.EquipmentTypes.HELMETS, 0);
            return em;
        }
        public EquipmentManager thinkingCap()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Thinking Cap", "thinking_cap", "An Upgraded Version Of The Scholars Cap That Will Increase Your Wisdom Even More!", 0, 0, 16, 0, BaceEquipment.EquipmentTypes.HELMETS, 0);
            return em;
        }
        public EquipmentManager leadersHelm()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Leaders Helm", "leaders_helm", "A Majestic Helm Handcrafted By The Leader Of A Small Village!", 0, 0, 0, 17, BaceEquipment.EquipmentTypes.HELMETS, 0);
            em.isImportantItem = true;
            return em;
        }
        public EquipmentManager moonCrown()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Moon Crown", "moon_crown", "When Used As An Item At Night It May Increase The Users Wisdom And Agility!", 0, 0, 0, 19, BaceEquipment.EquipmentTypes.HELMETS, 0);
            return em;
        }
        public EquipmentManager furryHead()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Furry Head", "furry_head", "An Addon To The Fursuit, Which Goes Compleately Over The Head!", -2, 0, 0, 9, BaceEquipment.EquipmentTypes.HELMETS, 0);
            em.isImportantItem = true;
            return em;
        }

    }
    public class Accessory_RingRegistry
    {
        public EquipmentManager bronzeRing()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Bronze Ring", "bronze_ring", "A Light Ring Made From Bronze!", 0, 0, 0, 1, BaceEquipment.EquipmentTypes.ACCESSORIES_RING, 0);
            return em;
        }
        public EquipmentManager ironRing()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Iron Ring", "iron_ring", "A Ring Made From Iron!", 0, 0, 0, 2, BaceEquipment.EquipmentTypes.ACCESSORIES_RING, 0);
            return em;
        }
        public EquipmentManager goldRing()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Gold Ring", "gold_ring", "A Ring Made From Iron!", 0, 0, 0, 3, BaceEquipment.EquipmentTypes.ACCESSORIES_RING, 0);
            return em;
        }
        public EquipmentManager silverRing()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Silver Ring", "silver_ring", "A Ring Made From Silver!", 0, 0, 0, 4, BaceEquipment.EquipmentTypes.ACCESSORIES_RING, 0);
            return em;
        }
        public EquipmentManager ringOfMagic()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Ring Of Magic", "ring_of_magic", "A Magic Ring Which Increases The Wearers MP!", 0, 0, 0, 4, BaceEquipment.EquipmentTypes.ACCESSORIES_RING, 0);
            return em;
        }
        public EquipmentManager healersRing()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Healers Ring", "healers_ring", "A Ring Which Allows The Wearer To Use Any Healing Spells!", 0, 0, 0, 5, BaceEquipment.EquipmentTypes.ACCESSORIES_RING, 0);
            return em;
        }
    }
    public class Accessory_FootwearRegistry
    {
        public EquipmentManager leatherBoots()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Leather Boots", "leather_boots", "Boots Made From Leather!", 10, 0, 0, 10, BaceEquipment.EquipmentTypes.ACCESSORIES_FOOTWEAR, 0);
            return em;
        }
        public EquipmentManager hindPaws()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Fursuit Hind Paws", "fursuit_hind_paws", "An Addon To The Fursuit, The Paws Of The Fursuit Which Go On The Feet!", -2, 0, 0, 15, BaceEquipment.EquipmentTypes.ACCESSORIES_FOOTWEAR, 0);
            em.isImportantItem = true;
            return em;
        }
    }
    public class Accessory_NecklaceRegistry
    {
        public EquipmentManager goldNecklace()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Gold Necklace", "gold_necklace", "A Shiney Necklace Made Of Pure Gold!", -0, 0, 0, 3, BaceEquipment.EquipmentTypes.ACCESSORIES_NECKLACE, 0);
            return em;
        }
        public EquipmentManager collar()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Fursuit Collar", "fursuit_collar", "An Addon To The Fursuit, Locks The Head To The Suit So The Suit Cannot Be Removed!", -2, -2, 2, 5, BaceEquipment.EquipmentTypes.ACCESSORIES_NECKLACE, 0);
            em.isImportantItem = true;
            return em;
        }
    }
    public class Accessory_BraceletRegistry
    {
        public EquipmentManager goldenBracelet()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Golden Bracelet", "golden_bracelet", "A Golden Bracelet That Can Increase The Wearers Attack Power", 0, 5, 0, 0, BaceEquipment.EquipmentTypes.ACCESSORIES_BRACELET, 0);
            return em;
        }
        public EquipmentManager forePaws()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Fursuit Forepaws", "fursuit_forepaws", "An Addon To The Fursuit, The Paws Of The Fursuit Which Go Over The Hands!", -2, 0, 0, 5, BaceEquipment.EquipmentTypes.ACCESSORIES_BRACELET, 0);
            em.isImportantItem = true;
            return em;
        }
    }
    public class Accessory_MiscRegistry
    {
        public EquipmentManager pawStraps()
        {
            EquipmentManager em = null;
            em = new EquipmentManager("Fursuit Paw Straps", "fursuit_paw_straps", "An Addon To The Fursuit, Locks The Paws To The Suit So The Suit Cannot be Removed!", -5, 0, 0, 0, BaceEquipment.EquipmentTypes.ACCESSORIES_MISC, 0);
            em.isImportantItem = true;
            return em;
        }
    }

}
