using UnityEngine;
 using System.Collections;
 
 public class Orbit : MonoBehaviour {
 
     public float turnSpeed = 4.0f;
     public Transform player;
 
     private Vector3 offset;

     public Vector3 off = new Vector3(0f, 1f, -1f);
 
     void Start () {
         offset = new Vector3(player.position.x, player.position.y + 1f, player.position.z  - 1f);
     }
 
     void LateUpdate()
     {
         //offset = new Vector3(player.position.x + off.x, player.position.y + off.y, player.position.z  + off.z);
         offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
         transform.position = player.position + offset; 
         transform.LookAt(player.position);
     }
 }