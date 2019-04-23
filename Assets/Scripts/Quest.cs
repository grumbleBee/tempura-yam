using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Quest {
    public int id;
    public string title;
    public string description;
    public int resultItemID;
 
    public Quest(int id, string title, string description, int resultItemID)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.resultItemID = resultItemID;
    }
}