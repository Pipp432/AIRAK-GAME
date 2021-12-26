using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCrop : MonoBehaviour
{
    
    public Inventory inventory;
    public FarmlandState state;
    Renderer plot;
    bool watered;

    private void Start()
    {
        plot = gameObject.GetComponent<Renderer>();
        state = gameObject.GetComponent<FarmlandState>();
        plot.enabled = true;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        watered = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && inventory.getWater() > 0 && !watered)
        {
           
            state.ChangeState(1);
            inventory.useWater(1);
            Debug.Log(inventory.getWater());
            watered = true;
            gameObject.tag = "WateredFarmland";
        }
        
    }
    




     
}

