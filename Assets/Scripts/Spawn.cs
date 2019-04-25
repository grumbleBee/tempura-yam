using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obj;
    public TimeManager tm;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObj();
        tm = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(tm.getCurrentState() == TimeManager.DayState.Day){
            if(tm.getPrevState() == TimeManager.DayState.Night){
                SpawnObj();
            }
        }
        
    }

    public void SpawnObj(){
        Instantiate(obj, transform);
    }
}
