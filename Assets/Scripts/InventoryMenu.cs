using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{

    public static bool inventoryActive;
    public GameObject inventoryUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)){
            if(inventoryActive){
                Deactivate();
            } else{
                Activate();
            }
        }
    }

    void Deactivate(){
        //inventoryUI.SetActive(false);
        Time.timeScale = 1f;
        inventoryActive = false;
    }

    void Activate(){
        //inventoryUI.SetActive(true);
        Time.timeScale = 0f;
        inventoryActive = true;
    }
}
