using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryUIController : MonoBehaviour
{
    public RectTransform thing;
    public RectTransform questUI;
    public RectTransform minimap;
    bool open;
    public GameObject player;
    RigidbodyFirstPersonController controller;
    // Start is called before the first frame update
    void Start()
    {
        open = false;
        controller = player.GetComponent<RigidbodyFirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)){
            if(!open){
                thing.DOAnchorPosY(0f, 1f);
                questUI.DOAnchorPosY(-50f, 1f);
                minimap.DOAnchorPosX(85f, 1f);
                controller.mouseLook.SetCursorLock(false);
                open = true;
            }else{
                thing.DOAnchorPosY(1000f, 1f);
                questUI.DOAnchorPosY(50f, 1f);
                minimap.DOAnchorPosX(-85f, 1f);
                controller.mouseLook.SetCursorLock(true);
                open = false;
            }
        }
    }
}
