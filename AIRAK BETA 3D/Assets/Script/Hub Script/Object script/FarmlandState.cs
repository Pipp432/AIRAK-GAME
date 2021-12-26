using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmlandState : MonoBehaviour
{
    public Material[] plotStates;
    Renderer plot;
    

    void Start()
    {
        plot = gameObject.GetComponent<Renderer>();
        plot.sharedMaterial = plotStates[0];
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crop") {
            plot.sharedMaterial =  plotStates[1];
            

        }
    }
    public void ChangeState(int i) {
        plot.sharedMaterial = plotStates[i];
    }
}
