using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObj(){
        Instantiate(obj, transform);
    }
}
