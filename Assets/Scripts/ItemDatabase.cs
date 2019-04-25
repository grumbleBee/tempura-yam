using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>();

    void Awake()
    {
        BuildItemDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string title)
    {
        return items.Find(item => item.title == title);
    }

    void BuildItemDatabase()
    {
        items = new List<Item>()
        {
            //-------------------------------------//
            //              PLANTS
            //------------------------------------//
            //pine
            new Item(1, "Blue Poplar", "Loves shade.", Resources.Load<Sprite>("Icons/BluePoplar"),
            new Dictionary<string, int> {
            }),
            //forest
            new Item(2, "Cutleaf Rosemary", "Leaves are delicious, and bark can be made into tea.", Resources.Load<Sprite>("Icons/CutleafRosemary"),
            new Dictionary<string, int> {
            }),
            //common
            new Item(3, "Dame's Harlequin", "All parts of this common plant can be used.", Resources.Load<Sprite>("Icons/DamesHarlequin"),
            new Dictionary<string, int> {
            }),
            //desert
            new Item(4, "Desert Feverfew", "Thrives in hot, dry climates.", Resources.Load<Sprite>("Icons/DesertFeverfew"),
            new Dictionary<string, int> {
            }),
            //desert (closer to ff)
            new Item(5, "Downy Redbud", "Watch out for thorns!", Resources.Load<Sprite>("Icons/DownyRedbud"),
            new Dictionary<string, int> {
            }),
            //mountain (actual mountain)
            new Item(6, "Milky Shadebush", "Usually found at high elevations.", Resources.Load<Sprite>("Icons/MilkyShadebush"),
            new Dictionary<string, int> {
            }),
            //pine/ff
            new Item(7, "Night Dewberry", "Only blooms at night.", Resources.Load<Sprite>("Icons/NightDewberry"),
            new Dictionary<string, int> {
            }),
            //forest
            new Item(8, "Queen's Ribwort", "Poisonous to most animals.", Resources.Load<Sprite>("Icons/QueensRibwort"),
            new Dictionary<string, int> {
            }),
            //beach
            new Item(9, "Sandy Amaryllis", "Can only grow in warm climates.", Resources.Load<Sprite>("Icons/SandyAmaryllis"),
            new Dictionary<string, int> {
            }),
            //common
            new Item(10, "Spring Eranthis", "Very hardy and easy to grow.", Resources.Load<Sprite>("Icons/SpringEranthis"),
            new Dictionary<string, int> {
            }),
            //beach/ff
            new Item(11, "Water Island Lavender", "Smells amazing, but tastes like soap.", Resources.Load<Sprite>("Icons/WaterIslandLavender"),
            new Dictionary<string, int> {
            }),
            //mountain (river)
            new Item(12, "Yellowbark Briar", "Grows in damp, sandy ground.", Resources.Load<Sprite>("Icons/YellowbarkBriar"),
            new Dictionary<string, int> {
            }),

            //-------------------------------------//
            //              POTIONS
            //------------------------------------//
            new Item(13, "Delicious Beverage", "My favorite!", Resources.Load<Sprite>("Potions/Bottle8"),
            new Dictionary<string, int> {
            }),
            new Item(14, "Sight Vial", "Potion to improve vision.", Resources.Load<Sprite>("Potions/Bottle3"),
            new Dictionary<string, int> {
            }),
            new Item(15, "Purification Potion", "Useful for disinfecting.", Resources.Load<Sprite>("Potions/Bottle12"),
            new Dictionary<string, int> {
            }),
            new Item(16, "Healing Flask", "Good for ailments of all kinds!", Resources.Load<Sprite>("Potions/Bottle10"),
            new Dictionary<string, int> {
            }),
            new Item(17, "Philter of Strength", "Improves strength, but tastes awful.", Resources.Load<Sprite>("Potions/Bottle9"),
            new Dictionary<string, int> {
            }),
            new Item(18, "Potion of Growth", "Encourages growth.", Resources.Load<Sprite>("Potions/Bottle7"),
            new Dictionary<string, int> {
            }),
            new Item(19, "Vial of Vitality", "Complicated recipe, lifesaving results.", Resources.Load<Sprite>("Potions/Bottle16"),
            new Dictionary<string, int> {
            })
        };
    }
}