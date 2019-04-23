using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int id;
    public Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        
    }

    public void Clickie(){
        if(inventory.playerItems.Count <= 32)
        {
            inventory.GiveItem(id);
            Destroy(gameObject);
        }

    }
}
