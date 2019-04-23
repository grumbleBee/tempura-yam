using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UICraftResult : MonoBehaviour, IPointerDownHandler {
    public SlotPanel slotPanel;
    public Inventory inventory;
    public Item resultItem;

    public void LateUpdate(){
        UIItem test = GetComponent<UIItem>();
        if(test != null && test.item != null){
            //Debug.Log(test.item.id);
            resultItem = test.item;
        } 
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        List<Item> toDelete = slotPanel.GetSlotContents();
        //slotPanel.EmptyAllSlots();
        if(toDelete != null){
            foreach(Item item in toDelete){
                if(item != null && item.id != null && inventory != null) inventory.RemoveItem(item.id);
            }
        }
        inventory.playerItems.Add(resultItem);
    }
}