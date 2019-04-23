using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{

    GameObject selected;
    Shader og;
    Renderer rend;
    bool frameSaver;
    Outline outline;

    // Start is called before the first frame update
    void Start()
    {
        frameSaver = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Bit shift the index of the layer (9) to get a bit mask
        int layerMask = 1 << 9;

        // This would cast rays only against colliders in layer 9.
        // But instead we want to collide against everything except layer 9. The ~ operator does this, it inverts a bitmask.
        //layerMask = ~layerMask;

        RaycastHit hit;

        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Hit");
            if(/*!frameSaver*/ true){
                selected = hit.collider.gameObject;
                outline = selected.GetComponent<Outline>();
                outline.enabled = true;
                frameSaver = true;
            }
            if(selected != null && (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0))){
                selected.GetComponent<Pickup>().Clickie();
            }
            
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            //Debug.Log("Did not Hit");
            if(selected != null){
                outline.enabled = false;
                frameSaver = false;
            }
        }
    }
}
