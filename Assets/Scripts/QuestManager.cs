using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();

    // Start is called before the first frame update
    void Start()
    {
        BuildQuestList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Quest GetQuest(int id)
    {
        return quests.Find(quest => quest.id == id);
    }

    void BuildQuestList(){
        quests = new List<Quest>()
        {
            new Quest(1, "test", "Let's gather materials! Find a Spring Eranthis. (Collect an item with left click or E)", 10),
            new Quest(2, "test", "Good work! Here's a tip: If you have too many items, you can get rid of them with the bottom section of the inventory.", 0),
            new Quest(3, "test", "Warm up your crafting skills! You can use a Spring Eranthis and a Cutleaf Rosemary to make tea.", 13),
            new Quest(4, "test", "Your first order has arrived! Make a Sight Vial out of Cutleaf Rosemary and Dame's Harlequin", 14),
            new Quest(5, "test", "Head north to find the ingredients for a Purification Potion: Queen's Ribwort, Spring Eranthis, and Downy Redbud.", 15),
            new Quest(6, "test", "Make a Healing Flask by combining a Purification Potion, Dame's Harlequin, and Desert Feverfew.", 16),
            new Quest(7, "test", "Head to the mountains to find the ingredients for a Philter of Strength: 2 Yellowbark Briars and 1 Milky Shadebush.", 17),
            new Quest(8, "test", "Hold onto that! Next, head South to make a Potion of Growth. Collect 3 Dame's Harlequin's, 2 Blue Poplars, and a Night Dewberry.", 18),
            new Quest(9, "test", "Great! Now, let's make a Vial of Vitality. Combine the Potion of Growth and the Philter of Strength with as much Water Island Lavender as you can.", 19)
        };
    }
}
