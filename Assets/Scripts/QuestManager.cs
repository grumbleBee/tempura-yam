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
            new Quest(1, "test_quest1", "Fetch a spring eranthus", 10),
            new Quest(2, "test_quest2", "Tip: If you have too many items, you can get rid of them with the bottom section of the inventory.", 0),
            new Quest(3, "test_quest2", "get 2 blue and 1 green to create teal", 5),
            new Quest(4, "test_quest2", "get 1 blue and 1 red to create purple", 7)
        };
    }
}
