using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public int dayCount;
    public int dayTime;
    private float dayRotSpeed;
    public int nightTime;
    private float nightRotSpeed;
    public Spawn[] spawners;
    public QuestManager questManager;
    public Inventory inventory;
    //public SlotPanel inventoryPanel;
    public QuestUI questUI;

    public enum DayState{
        Day,
        Night
    }

    private DayState dayState;
    private DayState prevState;

    public DayState getCurrentState(){
        return dayState;
    }

    public DayState getPrevState(){
        return prevState;
    }

    // Start is called before the first frame update
    void Start()
    {
        dayRotSpeed = 180.0f / dayTime;
        nightRotSpeed = 180.0f / nightTime;
        dayState = DayState.Day;
        prevState = DayState.Night;
        dayCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(dayState == DayState.Day){
            transform.Rotate(0, 0, dayRotSpeed * Time.deltaTime);
        } else{
            transform.Rotate(0, 0, nightRotSpeed * Time.deltaTime);
        }
        if(transform.eulerAngles.z > 180){
            dayState = DayState.Night;
            if(prevState == DayState.Day) HandleNewNight();
            prevState = DayState.Night;
        } else{ dayState = DayState.Day; 
                if(prevState == DayState.Night) HandleNewDay();
                prevState = DayState.Day;
        }
        //Debug.Log(transform.eulerAngles.z);
        //Debug.Log("It's " + dayState);
    }

    void HandleNewDay(){
        if(dayCount <= questManager.quests.Count){
            questUI.WriteToUI(questManager.GetQuest(dayCount).description);
        }
        else{
            questUI.WriteToUI("Excellent work!");
        }
        foreach(Spawn spawner in spawners){
            if(spawner.transform.childCount == 0){
                spawner.SpawnObj();
            }
        }
    }

    void HandleNewNight(){
        //Debug.Log(toRemove.id);
        if(dayCount <= questManager.quests.Count){
            Item toRemove = inventory.CheckForItem(questManager.GetQuest(dayCount).resultItemID);
            //Debug.Log(dayCount);
            //Debug.Log(questManager.GetQuest(dayCount).resultItemID);
            if(toRemove != null){
                inventory.RemoveItem(questManager.GetQuest(dayCount).resultItemID);
                dayCount++;
            } else if(questManager.GetQuest(dayCount).resultItemID == 0){
                dayCount++;
            }
        }
    }
}
