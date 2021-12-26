using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float turnSpeed = 1.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //this.rotation = Quaternion.Euler(new Vector3(0.2,0,0))*target.localRotation;
    this.transform.rotation = Quaternion.Euler(0,turnSpeed,0)*target.transform.localRotation;
    }
}
