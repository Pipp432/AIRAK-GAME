using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : MonoBehaviour,ICanGrow
{
    Transform crop;
    
    MeshRenderer[] cropMaterial;
    public Material grownMaterial;
    float timeBetweenGrowth = 1.5f;
    int growCounter = 0  ;
    
 
    void Start()
    {
        crop = this.GetComponent<Transform>();
        cropMaterial = this.GetComponentsInChildren<MeshRenderer>();
        InvokeRepeating("Grow", timeBetweenGrowth, timeBetweenGrowth);
    }

    public void Grow()
    {
        if (growCounter < 16)
        {
            crop.position += new Vector3(0, 0.05f, 0);
            growCounter++;
           
        }
        if (growCounter == 16) {
            foreach (MeshRenderer subcrop in cropMaterial) {
                subcrop.sharedMaterial = grownMaterial;
                
            }
            gameObject.tag = "Crop";
            
        }
    }

    


}
