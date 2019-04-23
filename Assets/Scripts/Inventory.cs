using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    [SerializeField]
    private UIInventory inventoryUI;
    public List<Item> playerItems = new List<Item>();
    private ItemDatabase itemDatabase;
    

private void Awake()
    {
        itemDatabase = FindObjectOfType<ItemDatabase>();
        playerItems = new List<Item>();
    }

private void Start(){
    /* GiveItem(1);
    GiveItem(2);
    GiveItem(3);
    */
}

public void Update(){
    /* Debug.Log("current items:");
    foreach(Item i in playerItems){
        if(i != null){
            Debug.Log(i.id);
        }
    } */
}

public void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);        
        inventoryUI.AddItemToUI(itemToAdd);
        playerItems.Add(itemToAdd);
    }

public void GiveItem(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        inventoryUI.AddItemToUI(itemToAdd);
        playerItems.Add(itemToAdd);
    }

 public Item CheckForItem(int id)
    {
        return playerItems.Find(item => item.id == id);
    }

public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);

        if (itemToRemove != null)
        {
            playerItems.Remove(itemToRemove);
            inventoryUI.RemoveItemFromUI(itemToRemove);
        }
    }
}