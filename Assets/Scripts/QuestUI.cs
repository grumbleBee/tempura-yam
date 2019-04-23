using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestUI : MonoBehaviour
{
    //public QuestManager questManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WriteToUI(string message){
        TextMeshProUGUI textmesh = GetComponent<TextMeshProUGUI>();
        textmesh.text = message;
    }
}
