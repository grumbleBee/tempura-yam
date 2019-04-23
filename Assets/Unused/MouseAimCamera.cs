using UnityEngine;
public class MouseAimCamera : MonoBehaviour {
    public GameObject target;
    public GameObject followTarget;
    public float rotateSpeed = 5;
    Vector3 offset;

    public float xmin, xmax, ymin, ymax;
     
    void Start() {
        offset = target.transform.position - transform.position;
    }
     
    void LateUpdate() {
        float horizontal = Mathf.Clamp(Input.GetAxis("Mouse X") * rotateSpeed, xmin, xmax);
        float vertical = Mathf.Clamp(Input.GetAxis("Mouse Y") * rotateSpeed, ymin, ymax);
        //target.transform.Rotate(0, horizontal, 0);
        transform.RotateAround(target.transform.position, Vector3.up, horizontal);
        transform.Rotate(-vertical, 0, 0);
    }
}