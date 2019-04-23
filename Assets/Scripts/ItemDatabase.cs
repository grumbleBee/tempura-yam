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
            new Item(1, "Blue Poplar", "", Resources.Load<Sprite>("Icons/BluePoplar"),
            new Dictionary<string, int> {
            }),
            new Item(2, "Cutleaf Rosemary", "", Resources.Load<Sprite>("Icons/CutleafRosemary"),
            new Dictionary<string, int> {
            }),
            new Item(3, "Dame's Harlequin", "", Resources.Load<Sprite>("Icons/DamesHarlequin"),
            new Dictionary<string, int> {
            }),
            new Item(4, "Desert Feverfew", "", Resources.Load<Sprite>("Icons/DesertFeverfew"),
            new Dictionary<string, int> {
            }),
            new Item(5, "Downy Redbud", "test", Resources.Load<Sprite>("Icons/DownyRedbud"),
            new Dictionary<string, int> {
            }),
            new Item(6, "Milky Shadebush", "", Resources.Load<Sprite>("Icons/MilkyShadebush"),
            new Dictionary<string, int> {
            }),
            new Item(7, "Night Dewberry", "", Resources.Load<Sprite>("Icons/NightDewberry"),
            new Dictionary<string, int> {
            }),
            new Item(8, "Queen's Ribwort", "", Resources.Load<Sprite>("Icons/QueensRibwort"),
            new Dictionary<string, int> {
            }),
            new Item(9, "Sandy Amaryllis", "", Resources.Load<Sprite>("Icons/SandyAmaryllis"),
            new Dictionary<string, int> {
            }),
            new Item(10, "Spring Eranthis", "", Resources.Load<Sprite>("Icons/SpringEranthis"),
            new Dictionary<string, int> {
            }),
            new Item(11, "Water Island Lavender", "", Resources.Load<Sprite>("Icons/WaterIslandLavender"),
            new Dictionary<string, int> {
            }),
            new Item(12, "Yellowbark Briar", "", Resources.Load<Sprite>("Icons/YellowbarkBriar"),
            new Dictionary<string, int> {
            })
        };
    }
}