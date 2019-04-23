using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour {
    [SerializeField]
    private SlotPanel[] slotPanels;

    public void AddItemToUI(Item item)
    {
        foreach(SlotPanel sp in slotPanels)
        {
            if (sp.ContainsEmptySlot())
            {
                sp.AddNewItem(item);
                break;
            }
        }
    }

    public void RemoveItemFromUI(Item item)
    {
        foreach(SlotPanel sp in slotPanels)
        {
            if (sp.Contains(item))
            {
                sp.RemoveItem(item);
                break;
            }
        }
    }
}