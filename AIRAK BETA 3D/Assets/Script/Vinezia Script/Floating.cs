using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    
    public float speed ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = new Vector3(0, Mathf.Sin(Time.time*speed),0)*height;
       
        
this.transform.position = 
        	this.transform.position + this.transform.localRotation*Vector3.up*Mathf.Sin(Time.time)*speed;
            }
    
}
