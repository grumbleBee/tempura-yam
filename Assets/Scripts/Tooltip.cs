using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tooltip : MonoBehaviour {
    TextMeshProUGUI textmesh;

	void Start () {
        textmesh = GetComponentsInChildren<TextMeshProUGUI>()[0];
        gameObject.SetActive(false); 
	}
    
    public void GenerateTooltip(Item item)
    {
        string statText = "";
        foreach(var stat in item.stats)
        {
            statText += "\n" + stat.Key.ToString() + ": " + stat.Value;
        }
        string tooltip = string.Format("<b>{0}</b>\n{1}\n<b>{2}</b>", item.title, item.description, statText);
        textmesh.text = tooltip;
        gameObject.SetActive(true);
    }
}